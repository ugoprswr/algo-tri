using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algo_tri
{
    public partial class FrmTriPeigne : Form
    {
        private int[] array;
        private int currentIndex;

        private const int arraySize = 10;
        private const int minValue = 1;
        private const int maxValue = 18;

        private const int cellWidth = 40;
        private const int cellHeight = 40;

        private const int startX = 50;
        private const int startY = 50;

        private const int delay = 500; // Délai entre chaque itération en millisecondes

        private Timer timer;
        private int[] sortedArray;

        private TextBox sortedTextBox;

        public FrmTriPeigne()
        {
            InitializeComponent();
            InitializeArray();
            InitializeTimer();
            InitializeUI();
        }

        private void FrmTriPeigne_Load(object sender, EventArgs e)
        {
            txbPseudoCode.Text = "PROCEDURE tri_peigne (TABLEAU a[1:n])\r\n    echange ← VRAI\r\n    decalage ← n\r\n    TANT QUE (decalage > 1 OU echange = VRAI)\r\n        decalage ← ENTIER(decalage / 1.3)\r\n        SI decalage < 1 ALORS decalage ← 1\r\n        echange ← FAUX\r\n        POUR i DE 1 À n - decalage FAIRE\r\n            SI a[i] > a[i+decalage] ALORS\r\n                echanger a[i] ET a[i+decalage]\r\n                echange ← VRAI\r\n            FIN SI\r\n        FIN POUR\r\n    FIN TANT QUE\r\nFIN PROCEDURE";
            txbCodeTriPeigne.Text = "void tri_peigne(int[] tableau)\r\n{\r\n    bool echange = true;\r\n    int decalage = tableau.Length;\r\n\r\n    while (decalage > 1 || echange)\r\n    {\r\n        decalage = (int)(decalage / 1.3);\r\n        if (decalage < 1)\r\n            decalage = 1;\r\n\r\n        echange = false;\r\n        for (int i = 0; i < tableau.Length - decalage; i++)\r\n        {\r\n            if (tableau[i] > tableau[i + decalage])\r\n            {\r\n                int temp = tableau[i];\r\n                tableau[i] = tableau[i + decalage];\r\n                tableau[i + decalage] = temp;\r\n                echange = true;\r\n            }\r\n        }\r\n    }\r\n}";

        }

        private void btnTrierTriPeigne_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            timer.Start();
        }

        private void InitializeUI()
        {
            Button showSortedButton = new Button();
            showSortedButton.Text = "Afficher le tableau trié";
            showSortedButton.Location = new Point(startX + 100, startY + cellHeight + startY);
            showSortedButton.Click += ShowSortedButton_Click;
            this.Controls.Add(showSortedButton);

            sortedTextBox = new TextBox();
            sortedTextBox.Multiline = false;
            sortedTextBox.ReadOnly = true;
            sortedTextBox.Location = new Point(startX, startY + 2 * cellHeight + 3 * startY);
            sortedTextBox.Size = new Size(arraySize * cellWidth, cellHeight);
            this.Controls.Add(sortedTextBox);
        }

        private void InitializeArray()
        {
            {
                Random random = new Random();
                array = new int[arraySize];
                HashSet<int> generatedNumbers = new HashSet<int>(); // Ensemble pour stocker les chiffres déjà générés

                for (int i = 0; i < arraySize; i++)
                {
                    int randomNumber;
                    do
                    {
                        randomNumber = random.Next(minValue, maxValue + 1);
                    } while (generatedNumbers.Contains(randomNumber)); // Vérifie si le chiffre a déjà été généré

                    generatedNumbers.Add(randomNumber); // Ajoute le chiffre généré à l'ensemble
                    array[i] = randomNumber;
                }
            }
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = delay;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < arraySize - 1)
            {
                array = Tri.TriPeigne(array);

                currentIndex++;
                Refresh();
            }
            else
            {
                timer.Stop();
                sortedArray = array; // Stocker le tableau trié
            }
            if (currentIndex == arraySize - 1)
            {
                timer.Stop();
                sortedArray = array; // Stocker le tableau trié
            }
        }

        private void FrmTriPeigne_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < array.Length; i++)
            {
                int xPos = startX + i * cellWidth;
                int yPos = startY;

                if (i >= array.Length - currentIndex)
                {
                    g.FillRectangle(Brushes.LightGreen, xPos, yPos, cellWidth, cellHeight);
                }

                g.DrawRectangle(Pens.Black, xPos, yPos, cellWidth, cellHeight);
                g.DrawString(array[i].ToString(), Font, Brushes.Black, xPos + cellWidth / 2 - 8, yPos + cellHeight / 2 - 8);
            }
        }
        private void ShowSortedButton_Click(object sender, EventArgs e)
        {
            sortedTextBox.Text = string.Join(", ", array);
        }
    }
}

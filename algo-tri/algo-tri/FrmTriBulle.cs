using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algo_tri
{
    public partial class FrmTriBulle : Form
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

        public FrmTriBulle()
        {
            InitializeComponent();
            InitializeArray();
            InitializeTimer();
            InitializeUI();
        }

        /// <summary>
        /// Chargement de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTriBulle_Load(object sender, EventArgs e)
        {
            txbPseudoCode.Text = "    PROCEDURE tri_bulle ( TABLEAU a[1:n])\r\n    passage ← 0\r\n    REPETER\r\n        permut ← FAUX\r\n        POUR i VARIANT DE 1 A n - 1 - passage FAIRE\r\n            SI a[i] > a[i+1] ALORS\r\n                echanger a[i] ET a[i+1]\r\n                permut ← VRAI\r\n            FIN SI\r\n        FIN POUR\r\n        passage ← passage + 1\r\n    TANT QUE permut = VRAI\r\n";
            txbCodeTriBulle.Text = "void tri_bulle(int[] tableau)\r\n        {\r\n            int passage = 0;\r\n            bool permutation = true;\r\n            int en_cours;\r\n\r\n            while (permutation)\r\n            {\r\n                permutation = false;\r\n                passage++;\r\n                for (en_cours = 0; en_cours < 20 - passage; en_cours++)\r\n                {\r\n                    if (tableau[en_cours] > tableau[en_cours + 1])\r\n                    {\r\n                        permutation = true;\r\n        int temp = tableau[en_cours];\r\n                        tableau[en_cours] = tableau[en_cours + 1];\r\n                        tableau[en_cours + 1] = temp;\r\n                    }\r\n                }\r\n            }\r\n        }";
        }
        /// <summary>
        /// Bouton permettant de démarrer le tri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrierTriBulle_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            timer.Start(); // On démarre le timer
        }

        /// <summary>
        /// Initialisation de l'interface utilisateur
        /// </summary>
        private void InitializeUI()
        {
            Button showSortedButton = new Button();
            showSortedButton.Text = "Afficher le tableau trié";
            showSortedButton.Location = new Point(startX + 100, startY + cellHeight + startY);
            showSortedButton.Click += ShowSortedButton_Click;
            this.Controls.Add(showSortedButton);

        }

        private void ShowSortedButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Array.Sort(array);
            currentIndex = -1; // Réinitialise currentIndex pour ne pas mettre en évidence une cellule
            Refresh();
        }



        /// <summary>
        /// Création d'un tableau de nombres aléatoires
        /// </summary>
        private void InitializeArray ()
        {
            Random random = new Random();
            array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
        }

        /// <summary>
        /// Initaliser le timer
        /// </summary>
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = delay;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < arraySize - 1) // Cela évite de continuer à trier le tableau une fois qu'il est entièrement trié
            {
                for (int i = 0; i < arraySize - currentIndex - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                currentIndex++;
                Refresh();
            }
            else
            {
                timer.Stop();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = panelElements.CreateGraphics();

            for (int i = 0; i < arraySize; i++)
            {
                int x = startX + 1 * cellWidth;
                int y = startY;

                if (i == currentIndex)
                    g.FillRectangle(Brushes.Red, x, y, cellWidth * i, cellHeight * i);

                g.DrawRectangle(Pens.Black, x, y, cellWidth, cellHeight);
                g.DrawString(array[i].ToString(), Font, Brushes.Black, x + cellWidth / 2 - 10, y + cellHeight / 2 - 10);
            }   


        }
    }
}

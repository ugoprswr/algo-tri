using System;
using System.Collections.Generic;
using System.ComponentModel;
/**
 * Projet Algo Tri TPI
 * Preiswerk Ugo
 * 2023
 */
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static algo_tri.Tri;

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

        private int[] sortedArray;


        public FrmTriBulle()
        {
            InitializeComponent();
            InitializeArray();
            InitializeTimer();
            DoubleBuffered = true;
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
        /// Création d'un tableau de nombres aléatoires
        /// </summary>
        private void InitializeArray()
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

        /// <summary>
        /// Initaliser le timer
        /// </summary>
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = delay;
            timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Fonction appelée à chaque tick du Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < arraySize - 1)
            {
                array = Tri.TriBulle(array);

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

        /// <summary>
        /// Elle est appelée chaque fois que la fenêtre doit être redessinée (par exemple, lorsque nous appelons Refresh())
        /// </summary>
        /// <param name="e"></param>
        protected async override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = panelElements.CreateGraphics();

            int maxValue = array.Max(); // Obtient la valeur maximale dans le tableau
            int scaleHeight = (panelElements.Height - startY) / maxValue + 2; // Calcul de l'échelle de hauteur

            int index = 0;
            foreach (int value in array)
            {
                int height = value * scaleHeight; // Calcule la hauteur proportionnelle à la valeur

                // Les coordonnées x et y sont calculées en fonction de l'indice de l'élément dans le tableau et de la taille des cellules
                int x = startX + index * cellWidth;
                int y = panelElements.Height - height;

                // mettre en évidence la cellule en cours de traitement pendant le tri
                if (index == currentIndex)
                    g.FillRectangle(Brushes.Red, x, y, cellWidth, height);

                g.DrawRectangle(Pens.Black, x, y, cellWidth, height);
                g.DrawString(value.ToString(), Font, Brushes.Black, x + cellWidth / 2 - 10, y + height / 2 - 10);

                index++;
                await Task.Delay(delay);
            }


        }


        private void lsbVitesse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpeed = lsbVitesse.SelectedItem.ToString();
            timer.Interval = GetDelayFromSpeed(selectedSpeed);
        }
    }
}

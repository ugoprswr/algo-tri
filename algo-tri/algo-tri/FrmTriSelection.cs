/**
 * Ugo Preiswerk
 * Projet TPI Algo
 * 2023
 */
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
    public partial class FrmTriSelection : BaseTriForm
    {
        public FrmTriSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction appelé 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < arraySize - 1)
            {
                array = Tri.TriSelection(array);

                currentIndex++;
                Refresh();
            }
            else
            {
                timer.Stop();
                sortedArray = array;
            }
        }

        /// <summary>
        /// Fonction appelée lorsque le formulaire est redessiné
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
                // donner une apparence animée au tri
                await Task.Delay(delay);
            }
        }

        /// <summary>
        /// Choix de la vitesse d'exécution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbVitesse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpeed = lsbVitesse.SelectedItem.ToString();
            timer.Interval = GetDelayFromSpeed(selectedSpeed);
        }

        /// <summary>
        /// Chargement de la Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTriSelection_Load(object sender, EventArgs e)
        {
            txbPseudoCode.Text = "    PROCEDURE tri_peigne ( TABLEAU a[1:n])\r\n    écart ← n\r\n    permut ← VRAI\r\n    REPETER\r\n        écart ← entier(écart / 1,3)\r\n        SI écart < 1 ALORS écart ← 1\r\n        permut ← FAUX\r\n        POUR i VARIANT DE 1 A n - écart FAIRE\r\n            SI a[i] > a[i+écart] ALORS\r\n                échanger a[i] ET a[i+écart]\r\n                permut ← VRAI\r\n            FIN SI\r\n        FIN POUR\r\n    TANT QUE permut OU écart > 1\r\n";
            txbCode.Text = "void tri_peigne(int[] tableau)\r\n        {\r\n            int n = tableau.Length;\r\n            int ecart = n;\r\n            bool permutation = true;\r\n\r\n            while (permutation || ecart > 1)\r\n            {\r\n                ecart = (int)(ecart / 1.3);\r\n                if (ecart < 1)\r\n                    ecart = 1;\r\n\r\n                permutation = false;\r\n\r\n                for (int i = 0; i < n - ecart; i++)\r\n                {\r\n                    if (tableau[i] > tableau[i + ecart])\r\n                    {\r\n                        int temp = tableau[i];\r\n                        tableau[i] = tableau[i + ecart];\r\n                        tableau[i + ecart] = temp;\r\n                        permutation = true;\r\n                    }\r\n                }\r\n            }\r\n        }";
        }
        
        /// <summary>
        /// Bouton de tri 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrierSelection_Click(object sender, EventArgs e)
        {
            StartTimer();
        }
    }
}

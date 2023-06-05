using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace algo_tri
{
    public partial class FrmTriShell : BaseTriForm
    {
        public FrmTriShell()
        {
            InitializeComponent();
        }

        protected override void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < arraySize - 1)
            {
                array = Tri.TriShell(array);

                currentIndex++;
                Refresh();
            }
            else
            {
                timer.Stop();
                sortedArray = array;
            }
        }

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

        /// <summary>
        /// Chargement de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTriShell_Load(object sender, EventArgs e)
        {
            txbPseudoCode.Text = "PROCEDURE tri_shell(TABLEAU a[1:n])\r\n    gap ← n/2\r\n    \r\n    TANT QUE gap > 0 FAIRE\r\n        POUR i DE gap À n FAIRE\r\n            temp ← a[i]\r\n            j ← i\r\n            \r\n            TANT QUE j >= gap ET a[j-gap] > temp FAIRE\r\n                a[j] ← a[j-gap]\r\n                j ← j - gap\r\n            \r\n            a[j] ← temp\r\n        \r\n        gap ← entier(gap/2)\r\n    FIN TANT QUE\r\nFIN PROCEDURE";
            txbCode.Text = "void TriShell(int[] tableau)\r\n{\r\n    int n = tableau.Length;\r\n    int gap = n / 2;\r\n\r\n    while (gap > 0)\r\n    {\r\n        for (int i = gap; i < n; i++)\r\n        {\r\n            int temp = tableau[i];\r\n            int j = i;\r\n\r\n            while (j >= gap && tableau[j - gap] > temp)\r\n            {\r\n                tableau[j] = tableau[j - gap];\r\n                j -= gap;\r\n            }\r\n\r\n            tableau[j] = temp;\r\n        }\r\n\r\n        gap /= 2;\r\n    }\r\n}";
        }
    }
}

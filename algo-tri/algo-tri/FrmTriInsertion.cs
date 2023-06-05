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
    public partial class FrmTriInsertion : BaseTriForm
    {
        public FrmTriInsertion()
        {
            InitializeComponent();
        }
        protected override void Timer_Tick(object sender, EventArgs e)
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

        private void FrmTriInsertion_Load(object sender, EventArgs e)
        {

        }
    }
}

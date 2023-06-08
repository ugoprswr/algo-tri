/**
 * Projet Algo Tri TPI
 * Preiswerk Ugo
 * 2023
 */
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
using static algo_tri.Tri;

namespace algo_tri
{
    public partial class FrmTriBulle : BaseTriForm
    {
        private bool isSorting = false;
        private int numberOfSwaps;
        public FrmTriBulle()
        {
            InitializeComponent();
            InitializeArray();
            InitializeTimer();
            DoubleBuffered = true;
        }

        private string GetCodePas()
        {
            List<string> codeLines = new List<string>();

            codeLines.Add("void tri_bulle(int[] tableau)");
            codeLines.Add("{");
            codeLines.Add("    int passage = 0;");
            codeLines.Add("    bool permutation = true;");
            codeLines.Add("    int en_cours;");
            codeLines.Add("");
            codeLines.Add("    while (permutation)");
            codeLines.Add("    {");
            codeLines.Add("        permutation = false;");
            codeLines.Add("        passage++;");
            codeLines.Add("        for (en_cours = 0; en_cours < 20 - passage; en_cours++)");
            codeLines.Add("        {");
            codeLines.Add("            if (tableau[en_cours] > tableau[en_cours + 1])");
            codeLines.Add("            {");
            codeLines.Add("                permutation = true;");
            codeLines.Add("                int temp = tableau[en_cours];");
            codeLines.Add("                tableau[en_cours] = tableau[en_cours + 1];");
            codeLines.Add("                tableau[en_cours + 1] = temp;");
            codeLines.Add("            }");
            codeLines.Add("        }");
            codeLines.Add("    }");
            codeLines.Add("}");

            return string.Join(Environment.NewLine, codeLines);
        }

        /// <summary>
        /// Chargement de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTriBulle_Load(object sender, EventArgs e)
        {
            txbCodePas.Text = GetCodePas();
            txbPseudoCode.Text = "    PROCEDURE tri_bulle ( TABLEAU a[1:n])\r\n    passage ← 0\r\n    REPETER\r\n        permut ← FAUX\r\n        POUR i VARIANT DE 1 A n - 1 - passage FAIRE\r\n            SI a[i] > a[i+1] ALORS\r\n                echanger a[i] ET a[i+1]\r\n                permut ← VRAI\r\n            FIN SI\r\n        FIN POUR\r\n        passage ← passage + 1\r\n    TANT QUE permut = VRAI\r\n";
            txbCodeTriBulle.Text = "void tri_bulle(int[] tableau)\r\n        {\r\n            int passage = 0;\r\n            bool permutation = true;\r\n            int en_cours;\r\n\r\n            while (permutation)\r\n            {\r\n                permutation = false;\r\n                passage++;\r\n                for (en_cours = 0; en_cours < 20 - passage; en_cours++)\r\n                {\r\n                    if (tableau[en_cours] > tableau[en_cours + 1])\r\n                    {\r\n                        permutation = true;\r\n        int temp = tableau[en_cours];\r\n                        tableau[en_cours] = tableau[en_cours + 1];\r\n                        tableau[en_cours + 1] = temp;\r\n                    }\r\n                }\r\n            }\r\n        }";
        }

        /// <summary>
        /// Bouton permettant de démarrer le tri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        /// <summary>
        /// Création d'un tableau de nombres aléatoires
        /// </summary>
        protected override void InitializeArray()
        {
            base.InitializeArray();
            numberOfSwaps = 0;
        }

        /// <summary>
        /// Fonction appelée à chaque tick du Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < arraySize - 1)
            {
                (array, numberOfSwaps) = Tri.TriBulle(array);
                currentIndex++;
                txbCodePas.SelectionStart = GetCodePosition(currentIndex);
                txbCodePas.ScrollToCaret();
                Refresh();
            }
            else
            {
                timer.Stop();
                sortedArray = array; // Stocker le tableau trié
                btnTrierTriBulle.Text = "Trier";

                MessageBox.Show($"Nombre de déplacements effectués : {numberOfSwaps}");
            }
            if (currentIndex == arraySize - 1)
            {
                timer.Stop();
                sortedArray = array; // Stocker le tableau trié
            }

            if (!isSorting)
            {
                timer.Stop();

                // Le tri est arrêté, rétablir le texte du bouton à "Trier"
                btnTrierTriBulle.Text = "Trier";
            }

        }

        private int GetCodePosition(int index)
        {
            // Obtient le code C# associé à chaque étape du tri
            string code = GetCodePas();

            // Initialise la position à 0 (par défaut)
            int position = 0;

            // Détermine la position du code en fonction de l'index de l'étape
            switch (index)
            {
                case 0:
                    position = 0; // Début du code
                    break;
                case 1:
                    position = code.IndexOf("permutation = false;", StringComparison.InvariantCultureIgnoreCase);
                    // Recherche la ligne de code "permutation = false;" et obtient sa position dans le code
                    break;
                case 2:
                    position = code.IndexOf("passage++;", StringComparison.InvariantCultureIgnoreCase);
                    // Recherche la ligne de code "passage++;" et obtient sa position dans le code
                    break;
                case 3:
                    position = code.IndexOf("for (en_cours = 0;", StringComparison.InvariantCultureIgnoreCase);
                    // Recherche la ligne de code "for (en_cours = 0;" et obtient sa position dans le code
                    break;
                case 4:
                    position = code.IndexOf("if (tableau[en_cours] > tableau[en_cours + 1])", StringComparison.InvariantCultureIgnoreCase);
                    // Recherche la ligne de code "if (tableau[en_cours] > tableau[en_cours + 1])" et obtient sa position dans le code
                    break;
                case 5:
                    position = code.IndexOf("int temp = tableau[en_cours];", StringComparison.InvariantCultureIgnoreCase);
                    // Recherche la ligne de code "int temp = tableau[en_cours];" et obtient sa position dans le code
                    break;
                case 6:
                    position = code.IndexOf("tableau[en_cours] = tableau[en_cours + 1];", StringComparison.InvariantCultureIgnoreCase);
                    // Recherche la ligne de code "tableau[en_cours] = tableau[en_cours + 1];" et obtient sa position dans le code
                    break;
                case 7:
                    position = code.IndexOf("tableau[en_cours + 1] = temp;", StringComparison.InvariantCultureIgnoreCase);
                    // Recherche la ligne de code "tableau[en_cours + 1] = temp;" et obtient sa position dans le code
                    break;
                default:
                    position = 0; // Valeur par défaut si l'index n'est pas valide
                    break;
            }

            // Retourne la position du code correspondant à l'index de l'étape
            return position;
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

        private void btnTrierTriBulle_Click(object sender, EventArgs e)
        {
            if (isSorting)
            {
                // Le tri est en cours, donc nous voulons arrêter le tri
                isSorting = false;
                btnTrierTriBulle.Text = "Trier";
                MessageBox.Show($"Nombre de déplacements effectués : {numberOfSwaps}");
            }
            else
            {
                // Le tri n'est pas en cours, donc nous voulons démarrer le tri
                isSorting = true;
                btnTrierTriBulle.Text = "Stop";

                currentIndex = 0;
                timer.Start(); // On démarre le timer            }

            }
        }
    }
}

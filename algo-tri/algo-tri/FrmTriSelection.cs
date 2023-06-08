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
    public partial class FrmTriSelection : BaseTriForm
    {
        private bool isSorting = false;
        private int numberOfSwaps;

        public FrmTriSelection()
        {
            InitializeComponent();
            InitializeArray();
            InitializeTimer();
            DoubleBuffered = true;
        }

        /// <summary>
        /// Retourne le code C# correspondant à une étape du tri
        /// </summary>
        /// <returns></returns>
        private string GetCodePas()
        {
            List<string> codeLines = new List<string>();

            codeLines.Add("void tri_selection(int[] tableau)");
            codeLines.Add("{");
            codeLines.Add("    int n = tableau.Length;");
            codeLines.Add("");
            codeLines.Add("    for (int i = 0; i < n - 1; i++)");
            codeLines.Add("    {");
            codeLines.Add("        int minIndex = i;");
            codeLines.Add("        for (int j = i + 1; j < n; j++)");
            codeLines.Add("        {");
            codeLines.Add("            if (tableau[j] < tableau[minIndex])");
            codeLines.Add("            {");
            codeLines.Add("                minIndex = j;");
            codeLines.Add("            }");
            codeLines.Add("        }");
            codeLines.Add("");
            codeLines.Add("        if (minIndex != i)");
            codeLines.Add("        {");
            codeLines.Add("            int temp = tableau[i];");
            codeLines.Add("            tableau[i] = tableau[minIndex];");
            codeLines.Add("            tableau[minIndex] = temp;");
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
        private void FrmTriSelection_Load(object sender, EventArgs e)
        {
            txbCodePas.Text = GetCodePas();
            txbPseudoCode.Text = "PROCEDURE tri_selection (TABLEAU a[1:n])\r\n    n ← TAILLE(a)\r\n    POUR i DE 1 À n - 1 FAIRE\r\n        minIndex ← i\r\n        POUR j DE i + 1 À n FAIRE\r\n            SI a[j] < a[minIndex] ALORS\r\n                minIndex ← j\r\n            FIN SI\r\n        FIN POUR\r\n\r\n        SI minIndex ≠ i ALORS\r\n            echanger a[i] ET a[minIndex]\r\n        FIN SI\r\n    FIN POUR";
            txbCode.Text = "void tri_selection(int[] tableau)\r\n        {\r\n            int n = tableau.Length;\r\n\r\n            for (int i = 0; i < n - 1; i++)\r\n            {\r\n                int minIndex = i;\r\n                for (int j = i + 1; j < n; j++)\r\n                {\r\n                    if (tableau[j] < tableau[minIndex])\r\n                    {\r\n                        minIndex = j;\r\n                    }\r\n                }\r\n\r\n                if (minIndex != i)\r\n                {\r\n                    int temp = tableau[i];\r\n                    tableau[i] = tableau[minIndex];\r\n                    tableau[minIndex] = temp;\r\n                }\r\n            }\r\n        }";
        }

        /// <summary>
        /// Initialiser le tableau de nombres
        /// </summary>
        protected override void InitializeArray()
        {
            base.InitializeArray();
            numberOfSwaps = 0;
        }

        /// <summary>
        /// Appelée à chaque tick du Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < arraySize - 1)
            {
                // Si l'index actuel est inférieur à la taille du tableau moins 1 (car les index commencent à 0)
                // cela signifie qu'il reste des éléments à trier

                // Appel de la fonction TriInsertion pour effectuer une étape de tri
                // La fonction retourne le tableau trié et le nombre de déplacements effectués
                (array, numberOfSwaps) = Tri.TriSelection(array);

                // Incrémente l'index actuel pour passer à l'étape suivante du tri
                currentIndex++;

                // Définit la position de départ du texte dans la zone de texte du code pas à pas
                txbCodePas.SelectionStart = GetCodePosition(currentIndex);

                // Fait défiler la zone de texte jusqu'à la position de départ
                txbCodePas.ScrollToCaret();

                // Rafraîchit l'affichage de la fenêtre de l'application
                Refresh();
            }
            else
            {
                // Si l'index actuel est égal à la taille du tableau moins 1
                // cela signifie que toutes les étapes de tri ont été effectuées

                // Arrête le minuteur
                timer.Stop();

                // Enregistre le tableau trié dans la variable sortedArray
                sortedArray = array;

                // Modifie le texte du bouton de tri pour afficher "Trier"
                btnTrierSelection.Text = "Trier";

                // Affiche une boîte de message indiquant le nombre de déplacements effectués
                MessageBox.Show($"Nombre de déplacements effectués : {numberOfSwaps}");
            }

            if (currentIndex == arraySize - 1)
            {
                // Si l'index actuel est égal à la taille du tableau moins 1
                // cela signifie que toutes les étapes de tri ont été effectuées

                // Arrête le minuteur
                timer.Stop();

                // Enregistre le tableau trié dans la variable sortedArray
                sortedArray = array;
            }

            if (!isSorting)
            {
                // Si le tri n'est pas en cours

                // Arrête le minuteur
                timer.Stop();

                // Modifie le texte du bouton de tri pour afficher "Trier"
                btnTrierSelection.Text = "Trier";
            }
        }

        /// <summary>
        /// Obtenir la position dans le code C# correspondant à une étape spécifique du tri
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int GetCodePosition(int index)
        {
            string code = GetCodePas();
            int position = 0;

            switch (index)
            {
                case 0:
                    position = 0;
                    break;
                case 1:
                    position = code.IndexOf("for (int i = 0;", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 2:
                    position = code.IndexOf("int minIndex = i;", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 3:
                    position = code.IndexOf("for (int j = i + 1;", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 4:
                    position = code.IndexOf("if (tableau[j] < tableau[minIndex])", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 5:
                    position = code.IndexOf("minIndex = j;", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 6:
                    position = code.IndexOf("if (minIndex != i)", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 7:
                    position = code.IndexOf("int temp = tableau[i];", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 8:
                    position = code.IndexOf("tableau[i] = tableau[minIndex];", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 9:
                    position = code.IndexOf("tableau[minIndex] = temp;", StringComparison.InvariantCultureIgnoreCase);
                    break;
                default:
                    position = 0;
                    break;
            }

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

        /// <summary>
        /// Obtenir la vitesse choisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbVitesse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpeed = lsbVitesse.SelectedItem.ToString();
            timer.Interval = GetDelayFromSpeed(selectedSpeed);
        }

        /// <summary>
        /// Click du bouton trier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrierSelection_Click(object sender, EventArgs e)
        {
            if (isSorting)
            {
                // Si le tri est en cours (le bouton est actuellement étiqueté "Stop")
                // Arrêter le tri en modifiant la variable isSorting à false
                isSorting = false;

                // Modifier le texte du bouton pour afficher "Trier"
                btnTrierSelection.Text = "Trier";

                // Afficher une boîte de dialogue avec le nombre de déplacements effectués
                MessageBox.Show($"Nombre de déplacements effectués : {numberOfSwaps}");
            }
            else
            {
                // Si le tri n'est pas en cours (le bouton est actuellement étiqueté "Trier")
                // Démarrer le tri en modifiant la variable isSorting à true
                isSorting = true;

                // Modifier le texte du bouton pour afficher "Stop"
                btnTrierSelection.Text = "Stop";

                // Réinitialiser l'index de tri à 0
                currentIndex = 0;

                // Démarrer le minuteur pour commencer le tri
                timer.Start();
            }
        }
    }
}

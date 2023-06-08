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

namespace algo_tri
{
    public partial class FrmTriInsertion : BaseTriForm
    {
        private bool isSorting = false;
        private int numberOfSwaps;

        public FrmTriInsertion()
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

            codeLines.Add("void tri_insertion(int[] tableau)");
            codeLines.Add("{");
            codeLines.Add("    int n = tableau.Length;");
            codeLines.Add("    for (int i = 1; i < n; i++)");
            codeLines.Add("    {");
            codeLines.Add("        int j = i;");
            codeLines.Add("        while (j > 0 && tableau[j - 1] > tableau[j])");
            codeLines.Add("        {");
            codeLines.Add("            int temp = tableau[j];");
            codeLines.Add("            tableau[j] = tableau[j - 1];");
            codeLines.Add("            tableau[j - 1] = temp;");
            codeLines.Add("            j--;");
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
        private void FrmTriInsertion_Load(object sender, EventArgs e)
        {
            txbCodePas.Text = GetCodePas();
            txbPseudoCode.Text = "    PROCEDURE tri_insertion ( TABLEAU a[1:n])\r\n    n ← taille(a)\r\n    POUR i VARIANT DE 1 A n - 1 FAIRE\r\n        j ← i\r\n        TANT QUE j > 0 ET a[j-1] > a[j] FAIRE\r\n            echanger a[j] ET a[j-1]\r\n            j ← j - 1\r\n        FIN TANT QUE\r\n    FIN POUR\r\n";
            txbCode.Text = "void tri_insertion(int[] tableau)\r\n        {\r\n            int n = tableau.Length;\r\n            for (int i = 1; i < n; i++)\r\n            {\r\n                int j = i;\r\n                while (j > 0 && tableau[j - 1] > tableau[j])\r\n                {\r\n                    int temp = tableau[j];\r\n                    tableau[j] = tableau[j - 1];\r\n                    tableau[j - 1] = temp;\r\n                    j--;\r\n                }\r\n            }\r\n        }";
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
                (array, numberOfSwaps) = Tri.TriInsertion(array);

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
                btnTrierTriInsertion.Text = "Trier";

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
                btnTrierTriInsertion.Text = "Trier";
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
                    position = code.IndexOf("for (int i = 1;", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 2:
                    position = code.IndexOf("int j = i;", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 3:
                    position = code.IndexOf("while (j > 0 && tableau[j - 1] > tableau[j])", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 4:
                    position = code.IndexOf("int temp = tableau[j];", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 5:
                    position = code.IndexOf("tableau[j] = tableau[j - 1];", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 6:
                    position = code.IndexOf("tableau[j - 1] = temp;", StringComparison.InvariantCultureIgnoreCase);
                    break;
                case 7:
                    position = code.IndexOf("j--;", StringComparison.InvariantCultureIgnoreCase);
                    break;
                default:
                    position = 0;
                    break;
            }

            return position;
        }

        protected async override void OnPaint(PaintEventArgs e)
        {
            // Appelle la méthode OnPaint de la classe de base pour effectuer le rendu de base de la fenêtre
            base.OnPaint(e);

            // Crée un objet Graphics à partir du panneau panelElements pour dessiner les éléments
            Graphics g = panelElements.CreateGraphics();

            // Trouve la valeur maximale dans le tableau
            int maxValue = array.Max();

            // Calcule l'échelle de hauteur pour ajuster les éléments en fonction de la hauteur du panneau
            int scaleHeight = (panelElements.Height - startY) / maxValue + 2;

            // Initialise l'index pour itérer à travers les éléments du tableau
            int index = 0;

            // Parcourt chaque élément du tableau pour effectuer le rendu
            foreach (int value in array)
            {
                // Calcule la hauteur proportionnelle à la valeur de l'élément
                int height = value * scaleHeight;

                // Calcule les coordonnées x et y pour dessiner l'élément à sa position correcte
                int x = startX + index * cellWidth;
                int y = panelElements.Height - height;

                // Vérifie si l'élément en cours de rendu est l'élément actuel en cours de tri
                if (index == currentIndex)
                {
                    // Remplit le rectangle de l'élément avec la couleur rouge pour le mettre en évidence
                    g.FillRectangle(Brushes.Red, x, y, cellWidth, height);
                }

                // Dessine le contour du rectangle de l'élément avec la couleur noire
                g.DrawRectangle(Pens.Black, x, y, cellWidth, height);

                // Dessine le texte de la valeur de l'élément au centre du rectangle
                g.DrawString(value.ToString(), Font, Brushes.Black, x + cellWidth / 2 - 10, y + height / 2 - 10);

                // Incrémente l'index pour passer à l'élément suivant du tableau
                index++;

                // Attend un court délai pour visualiser l'animation du tri
                await Task.Delay(delay);
            }

        }

        /// <summary>
        /// Choix de la vitesse de tri
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
        private void btnTrierTriInsertion_Click(object sender, EventArgs e)
        {
            if (isSorting)
            {
                // Si le tri est en cours (le bouton est actuellement étiqueté "Stop")
                // Arrêter le tri en modifiant la variable isSorting à false
                isSorting = false;

                // Modifier le texte du bouton pour afficher "Trier"
                btnTrierTriInsertion.Text = "Trier";

                // Afficher une boîte de dialogue avec le nombre de déplacements effectués
                MessageBox.Show($"Nombre de déplacements effectués : {numberOfSwaps}");
            }
            else
            {
                // Si le tri n'est pas en cours (le bouton est actuellement étiqueté "Trier")
                // Démarrer le tri en modifiant la variable isSorting à true
                isSorting = true;

                // Modifier le texte du bouton pour afficher "Stop"
                btnTrierTriInsertion.Text = "Stop";

                // Réinitialiser l'index de tri à 0
                currentIndex = 0;

                // Démarrer le minuteur pour commencer le tri
                timer.Start();
            }
        }
    }
}

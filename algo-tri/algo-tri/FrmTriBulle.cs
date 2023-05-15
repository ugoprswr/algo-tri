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
    public partial class FrmTriBulle : Form
    {
        public FrmTriBulle()
        {
            InitializeComponent();
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
        /// Bouton trier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrierTriBulle_Click(object sender, EventArgs e)
        {
            string vitesse = lsbVitesse.Text;
            string cas = lsbCas.Text;
            Functions.Trier(vitesse, cas);
        }
    }
}

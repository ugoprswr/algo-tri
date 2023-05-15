using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_tri
{
    public class Functions
    {
        /// <summary>
        /// Trier en fonctions de la vitesse et du cas
        /// </summary>
        /// <param name="vitesse"></param>
        /// <param name="cas"></param>
        public static void Trier(string vitesse, string cas)
        {
            if (vitesse == "Lent" && cas == "Le pire des cas")
            {
                return;
            }
        }

        /// <summary>
        /// Permet de trier grâce au tri à bulle
        /// </summary>
        /// <param name="tableau"></param>
        public static void TriBulle(int[] tableau)
        {
            int passage = 0;
            bool permutation = true;
            int en_cours;

            while (permutation)
            {
                permutation = false;
                passage++;
                for (en_cours = 0; en_cours < 20 - passage; en_cours++)
                {
                    if (tableau[en_cours] > tableau[en_cours + 1])
                    {
                        permutation = true;
                        int temp = tableau[en_cours];
                        tableau[en_cours] = tableau[en_cours + 1];
                        tableau[en_cours + 1] = temp;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_tri
{
    public class Tri
    {

       

        /// <summary>
        /// Méthode de tri à bulle
        /// </summary>
        /// <param name="tableau"></param>
        public static int[] TriBulle(int[] tableau)
        {
            int n = tableau.Length;
            bool permutation;
            do
            {
                permutation = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (tableau[i] > tableau[i + 1])
                    {
                        int temp = tableau[i];
                        tableau[i] = tableau[i + 1];
                        tableau[i + 1] = temp;
                        permutation = true;
                    }
                }
                n--;
            } while (permutation);

            return tableau;
        }

        /// <summary>
        /// Méthode de tri par insertion
        /// </summary>
        /// <param name="tableau"></param>
        public static void TriInsertion(int[] tableau)
        {
            int n = tableau.Length;
            for (int i = 1; i < n; i++)
            {
                int valeurCourante = tableau[i];
                int j = i - 1;
                while (j >= 0 && tableau[j] > valeurCourante)
                {
                    tableau[j + 1] = tableau[j];
                    j--;
                }
                tableau[j + 1] = valeurCourante;
            }
        }
        /// <summary>
        /// Méthode de Tri Peigne
        /// </summary>
        /// <param name="tableau"></param>
        public static int[] TriPeigne(int[] tableau)
        {
            int n = tableau.Length;
            int intervalle = n;
            bool permutation = true;

            while (intervalle > 1 || permutation)
            {
                intervalle = (int)(intervalle / 1.3);
                if (intervalle < 1)
                    intervalle = 1;

                permutation = false;
                for (int i = 0; i + intervalle < n; i++)
                {
                    if (tableau[i] > tableau[i + intervalle])
                    {
                        int temp = tableau[i];
                        tableau[i] = tableau[i + intervalle];
                        tableau[i + intervalle] = temp;
                        permutation = true;
                    }
                }
            }
            return tableau;
        }

        /// <summary>
        /// Méthode de tri par sélection
        /// </summary>
        /// <param name="tableau"></param>
        public static void TriSelection(int[] tableau)
        {
            int n = tableau.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (tableau[j] < tableau[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = tableau[i];
                    tableau[i] = tableau[minIndex];
                    tableau[minIndex] = temp;
                }
            }
        }

        /// <summary>
        /// Méthode de Tri Shell
        /// </summary>
        /// <param name="tableau"></param>
        public static void TriShell(int[] tableau)
        {
            int n = tableau.Length;
            int intervalle = 1;

            while (intervalle < n / 3)
            {
                intervalle = intervalle * 3 + 1;
            }

            while (intervalle >= 1)
            {
                for (int i = intervalle; i < n; i++)
                {
                    int valeurCourante = tableau[i];
                    int j = i;

                    while (j >= intervalle && tableau[j - intervalle] > valeurCourante)
                    {
                        tableau[j] = tableau[j - intervalle];
                        j -= intervalle;
                    }

                    tableau[j] = valeurCourante;
                }

                intervalle = intervalle / 3;
            }
        }
        public static int GetDelayFromSpeed(string speed)
        {
            switch (speed)
            {
                case "Lent":
                    return 1000; // Délai de 1 seconde (vitesse lente)
                case "Rapide":
                    return 200; // Délai de 200 millisecondes (vitesse rapide)
                default:
                    return 500; // Délai par défaut de 500 millisecondes
            }
        }
    }
}

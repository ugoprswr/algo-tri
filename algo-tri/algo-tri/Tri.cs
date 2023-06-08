/**
 * Ugo Preiswerk
 * Projet TPI Algo
 * 2023
 */
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
        public static (int[], int) TriBulle(int[] tableau)
        {
            int n = tableau.Length;  // Obtenir la taille du tableau
            bool permutation;  // Indicateur pour vérifier si des permutations ont été effectuées
            int numberOfSwaps = 0;  // Nombre total de permutations effectuées

            do
            {
                permutation = false;  // Réinitialiser l'indicateur de permutation à chaque itération
                for (int i = 0; i < n - 1; i++)  // Parcourir le tableau
                {
                    if (tableau[i] > tableau[i + 1])  // Vérifier si une permutation est nécessaire
                    {
                        int temp = tableau[i];  // Effectuer l'échange entre les éléments
                        tableau[i] = tableau[i + 1];
                        tableau[i + 1] = temp;

                        permutation = true;  // Indiquer qu'une permutation a été effectuée
                        numberOfSwaps++;  // Incrémenter le nombre total de permutations
                    }
                }
                n--;  // Réduire la taille du tableau à chaque itération
            } while (permutation);  // Répéter tant que des permutations sont effectuées

            return (tableau, numberOfSwaps);  // Retourner le tableau trié et le nombre de permutations effectuées
        }


        /// <summary>
        /// Méthode de tri par insertion
        /// </summary>
        /// <param name="tableau"></param>
        public static (int[], int) TriInsertion(int[] tableau)
        {
            int numberOfSwaps = 0;  // Nombre total de permutations effectuées
            int n = tableau.Length;  // Obtenir la taille du tableau

            for (int i = 1; i < n; i++)  // Parcourir le tableau à partir de l'index 1
            {
                int valeurCourante = tableau[i];  // Stocker la valeur actuelle à insérer dans sa position correcte
                int j = i - 1;  // Initialiser l'index du précédent élément

                numberOfSwaps++;  // Incrémenter le nombre total de permutations

                while (j >= 0 && tableau[j] > valeurCourante)  // Déplacer les éléments plus grands vers la droite
                {
                    tableau[j + 1] = tableau[j];  // Décaler l'élément vers la droite
                    j--;  // Décrémenter l'index pour vérifier les éléments précédents
                }

                tableau[j + 1] = valeurCourante;  // Insérer la valeur courante à sa position correcte
            }

            return (tableau, numberOfSwaps);  // Retourner le tableau trié et le nombre de permutations effectuées

        }
        /// <summary>
        /// Méthode de Tri Peigne
        /// </summary>
        /// <param name="tableau"></param>
        public static (int[], int) TriPeigne(int[] tableau)
        {
            int n = tableau.Length;  // Obtenir la taille du tableau
            int intervalle = n;  // Initialiser l'intervalle de comparaison
            bool permutation = true;  // Variable pour vérifier si des permutations sont effectuées
            int numberOfSwaps = 0;  // Nombre total de permutations effectuées

            while (intervalle > 1 || permutation)  // Continuer tant que l'intervalle est supérieur à 1 ou qu'il y a eu des permutations
            {
                intervalle = (int)(intervalle / 1.3);  // Réduire l'intervalle selon le facteur 1.3 (facteur empirique pour améliorer l'efficacité)
                if (intervalle < 1)
                    intervalle = 1;  // Si l'intervalle devient inférieur à 1, le fixer à 1 pour terminer le tri

                permutation = false;  // Réinitialiser la variable de permutation

                for (int i = 0; i + intervalle < n; i++)  // Parcourir le tableau avec l'intervalle spécifié
                {
                    if (tableau[i] > tableau[i + intervalle])  // Vérifier si une permutation est nécessaire
                    {
                        int temp = tableau[i];
                        tableau[i] = tableau[i + intervalle];
                        tableau[i + intervalle] = temp;
                        permutation = true;  // Indiquer qu'une permutation a été effectuée
                        numberOfSwaps++;  // Incrémenter le nombre total de permutations
                    }
                }
            }

            return (tableau, numberOfSwaps);  // Retourner le tableau trié et le nombre de permutations effectuées

        }

        /// <summary>
        /// Méthode de tri par sélection
        /// </summary>
        /// <param name="tableau"></param>
        public static (int[], int) TriSelection(int[] tableau)
        {
            int n = tableau.Length;  // Obtenir la taille du tableau
            int numberOfSwaps = 0;  // Nombre total de permutations effectuées

            for (int i = 0; i < n - 1; i++)  // Parcourir le tableau jusqu'à l'index avant le dernier
            {
                int minIndex = i;  // Index de la valeur minimale, initialisé à l'index actuel

                for (int j = i + 1; j < n; j++)  // Parcourir le reste du tableau à partir de l'index suivant
                {
                    if (tableau[j] < tableau[minIndex])  // Vérifier si une valeur plus petite est trouvée
                    {
                        minIndex = j;  // Mettre à jour l'index de la valeur minimale
                    }
                }

                if (minIndex != i)  // Vérifier si l'index de la valeur minimale est différent de l'index actuel
                {
                    int temp = tableau[i];  // Effectuer la permutation en échangeant les valeurs
                    tableau[i] = tableau[minIndex];
                    tableau[minIndex] = temp;
                    numberOfSwaps++;  // Incrémenter le nombre total de permutations
                }
            }

            return (tableau, numberOfSwaps);  // Retourner le tableau trié et le nombre de permutations effectuées

        }

        /// <summary>
        /// Méthode de Tri Shell
        /// </summary>
        /// <param name="tableau"></param>
        public static (int[], int) TriShell(int[] tableau)
        {
            int n = tableau.Length;  // Obtenir la taille du tableau
            int intervalle = 1;  // Initialiser l'intervalle avec la valeur de départ
            int numberOfSwaps = 0;  // Nombre total de permutations effectuées

            while (intervalle < n / 3)  // Déterminer l'intervalle initial selon la séquence de Shell
            {
                intervalle = intervalle * 3 + 1;
            }

            while (intervalle >= 1)  // Tant que l'intervalle est supérieur ou égal à 1
            {
                for (int i = intervalle; i < n; i++)  // Parcourir le tableau à partir de l'intervalle
                {
                    int valeurCourante = tableau[i];  // Stocker la valeur courante
                    int j = i;  // Initialiser l'index j avec i

                    while (j >= intervalle && tableau[j - intervalle] > valeurCourante)
                    {
                        tableau[j] = tableau[j - intervalle];  // Effectuer les décalages vers la droite
                        j -= intervalle;  // Mettre à jour l'index j en réduisant l'intervalle
                    }

                    tableau[j] = valeurCourante;  // Insérer la valeur courante à la position correcte
                    numberOfSwaps++;  // Incrémenter le nombre total de permutations
                }

                intervalle = intervalle / 3;  // Réduire l'intervalle selon la séquence de Shell
            }

            return (tableau, numberOfSwaps);  // Retourner le tableau trié et le nombre de permutations effectuées

        }

        /// <summary>
        /// Obtenir la vitesse choisie
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
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

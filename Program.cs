using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableauExercice3
{
    class Program
    {
        /// <summary>
        /// Calcul de la moyenne 
        /// </summary>
        /// <param name="notes">Tableau de notes</param>
        /// <returns>moyene calculée</returns>
        static float moyenne(float[])
        {
            ...            
            return moyenne;
        }
        static void Main(string[] args)
        {
            // Saisie de la dimension (taille) du tableau 
            Console.Write("Indiquez la dimension du tableau de note : ");
            int ...

            // Déclaration du tableau
            int[] notes = new int[...];

            // Déclaration de la variable qui va contenir la somme des notes
            ...

            // Saisie des notes
            for (int i = 0; i < ...; i++)
            {
                Console.Write("Entrez une note  : ");
                note[i] = int.Parse(Console.ReadLine());             
            }

            // Calcul de la moyenne sans utiliser de fonction
            // en faisant tout d'abord la somme des notes avec une boucle
            ...

            // Calcul de la moyenne en utilisant une fonction appelée  moyenne()
            ...
        }
    }
}

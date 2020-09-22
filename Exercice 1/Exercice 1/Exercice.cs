using Exercice_1.Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_1
{
    public class Exercice
    {
        public static void ExerciceARTICLE()
        {
            var article1 = new Article("IPhone", 1500, 1);
            var article2 = new Article("IPad", 700, 6);
            var article3 = new Article("IMac", 3800, 2);

            Console.WriteLine("Combien voulez-vous ajouter au premier article ? ");
            article1.Ajouter(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Combien voulez-vous retirer au second article ? ");
            article2.Retirer(Int32.Parse(Console.ReadLine()));

            article1.Afficher();
            article2.Afficher();
            article3.Afficher();
        }

        public static void ExerciceARTICLETYPE()
        {

        }
    }
}

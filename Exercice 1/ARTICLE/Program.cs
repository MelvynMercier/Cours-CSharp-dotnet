using ARTICLE.Structures;
using System;

namespace ARTICLE
{
    class Program
    {
        static void Main(string[] args)
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
    }
}

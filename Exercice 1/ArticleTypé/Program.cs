using ArticleTypé.Structures;
using System;

namespace ArticleTypé
{
    class Program
    {
        static void Main(string[] args)
        {
            var article1 = new Article("Chemise", 15, 1, Structures.Type.Habillement);
            var article2 = new Article("JetSki", 15000, 6, Structures.Type.Loisir);

            article1.Afficher();
            article2.Afficher();

            article1.Ajouter(50);
            article2.Retirer(400);

            article1.Afficher();
            article2.Afficher();
        }
    }
}

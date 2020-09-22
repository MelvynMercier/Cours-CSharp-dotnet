using ArticleTableau.Structures;
using System;
using System.Collections.Generic;

namespace ArticleTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            var listArticle = new List<Article>();
            
            listArticle.Add(new Article("Chemise", 15, 1, Structures.Type.Habillement));
            listArticle.Add(new Article("JetSki", 15000, 6, Structures.Type.Loisir));
            listArticle.Add(new Article("Bateau", 51000, 6, Structures.Type.Loisir));

            listArticle.ForEach(a =>
            {
                Console.WriteLine(a.Nom);
                Console.WriteLine(a.Prix);
                Console.WriteLine(a.Quantite);
                Console.WriteLine(a.TypeType);
                Console.WriteLine("");
            });
        }
    }
}

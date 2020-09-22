using System;
using System.Collections.Generic;
using System.Text;

namespace ARTICLE.Structures
{
    public class Article
    {
        public string Nom { get; set; }
        public int? Prix { get; set; }
        public int? Quantite { get; set; }

        public Article(string Nom, int Prix, int Quantite)
        {
            this.Nom = Nom;
            this.Prix = Prix;
            this.Quantite = Quantite;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + this.Nom);
            Console.WriteLine("Prix: " + this.Prix);
            Console.WriteLine("Quantité: " + this.Quantite);
        }

        public void Ajouter(int Integer)
        {
            this.Prix = this.Prix + Integer;
            Console.WriteLine("Prix: " + this.Prix);
        }

        public void Retirer(int Integer)
        {
            this.Prix = this.Prix - Integer;
            Console.WriteLine("Prix: " + this.Prix);
        }
    }
}

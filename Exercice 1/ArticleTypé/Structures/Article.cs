using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleTypé.Structures
{
    public enum Type
    {
        Alimentaire, Droguerie, Habillement, Loisir
    }

    public class Article
    {
        public string Nom { get; set; }
        public int? Prix { get; set; }
        public int? Quantite { get; set; }
        public Type TypeType { get; set; }

        public Article(string Nom, int Prix, int Quantite, Type type)
        {
            this.Nom = Nom;
            this.Prix = Prix;
            this.Quantite = Quantite;
            this.TypeType = type;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + this.Nom);
            Console.WriteLine("Prix: " + this.Prix);
            Console.WriteLine("Quantité: " + this.Quantite);
            Console.WriteLine("Type: " + this.TypeType);
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

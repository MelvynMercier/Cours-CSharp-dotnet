using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Classes
{
    public class Poche : Livre
    {
        private string Categorie;
        public string MaCategorie
        {
            get { return Categorie; }
            set { Categorie = value; }
        }
        public Poche(string Categorie, string Isbn, int NbPages, string Designation, double Prix) : base(Isbn, NbPages, Designation, Prix) { this.MaCategorie = Categorie; }

    }
}

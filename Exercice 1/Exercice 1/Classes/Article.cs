using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_1.Classes
{
    public class Article
    {
        protected string Designation { get; set; }
        protected double Prix { get; set; }

        public string Acheter()
        {
            return this.Designation + " " + this.Prix;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_1.Classes
{
    public class Disque : Article
    {
        protected string Label { get; set; }

        public string Ecouter()
        {
            return this.Label;
        }
    }
}

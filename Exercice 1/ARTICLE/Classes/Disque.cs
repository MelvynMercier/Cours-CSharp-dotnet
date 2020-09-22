using System;
using System.Collections.Generic;
using System.Text;

namespace ARTICLE.Classes
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

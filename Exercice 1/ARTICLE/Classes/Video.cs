﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ARTICLE.Classes
{
    public class Video : Article
    {
        protected double Duree { get; set; }

        public double Afficher()
        {
            return this.Duree;
        }
    }
}

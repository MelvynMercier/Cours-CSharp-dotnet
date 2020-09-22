using System;
using System.Collections.Generic;
using System.Text;

namespace ARTICLE.Classes
{
    public class Livre : Article
    {
        protected string Isbn { get; set; }
        protected int? nbPages { get; set; }
    }
}

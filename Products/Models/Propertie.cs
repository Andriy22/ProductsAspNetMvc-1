using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class Propertie
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public virtual  Product Product { get; set; }
    }
}
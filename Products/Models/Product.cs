using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public IEnumerable<Properties> Properties { get; set; }
        public int IdDescription { get; set; }

    }
}
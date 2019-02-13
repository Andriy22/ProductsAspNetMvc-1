using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class Product
    {

        public Product()
        {
            Properties = new HashSet<Propertie>();
            Descriptions = new HashSet<Description>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public virtual ICollection<Propertie> Properties { get; set; }
        public virtual ICollection< Description> Descriptions { get; set; }

    }
}
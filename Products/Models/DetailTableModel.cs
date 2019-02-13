using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class DetailTableModel
    {
        public Product Product { get; set; }
        public ICollection<Description> Descriptions { get; set; }
        public ICollection<Propertie> Properties { get; set; }

    }
}
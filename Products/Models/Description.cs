using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Products.Models
{
    public class Description
    {
        public int Id { get; set; }

        public int IdProduct { get; set; }

        public string Text { get; set; }
    }
}
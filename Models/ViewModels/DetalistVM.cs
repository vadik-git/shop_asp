using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.ViewModels
{
    public class DetalistVM
    {
        public Product Product { get; set; }
        public bool InCart { get; set; }
        public DetalistVM()
        {
            Product = new Product();
        }
    }
}

using DupDetector.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public class Detector
    {
        private List<Product> Products;

        public Detector(List<Product> products)
        {
            this.Products = products;
        }


    }
}

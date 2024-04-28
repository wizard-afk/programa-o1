using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atv05.Data;
using Atv05.Models;

namespace Atv05.Repository
{
    public class ProductRepository
    {
        public void Save (Product product)
        {
            DataSet.Products.Add(product);
        }

        public Product Retrieve(string name)
        {
            foreach(var p in DataSet.Product)
            {
                if( p.ProductName == name )
                    return p;
            }

            return null;
        }
    }
}
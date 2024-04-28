using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atv05.Models
{
    public class OrderItem
    {
        public Product Product {get; set;}
        public double Quantitu {get; set;}
        public double PurchasePrice {get; set;} 
        public bool Validate()
        {
            return true;
        }

        public OrderItem Retrieve()
        {
            return new OrderItem();
        }

        public void Save(OrderItem orderItem)
        {
            
        }
    
    }
}
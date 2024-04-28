using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atv05.Data;
using Atv05.Models;

namespace Atv05.Repository
{
    public class OrderRepository
    {
       public void Save (Order order)
        {
            DataSet.Orders.Add(order);
        }

        public Order Retrieve(int id)
        {
            foreach(var o in DataSet.Orders)
            {
                if( o. == id )
                    return o;
            }

            return null;
        } 
    }
}
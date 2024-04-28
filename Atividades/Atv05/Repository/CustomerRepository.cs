using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atv05.Models;
using Atv05.Data;

namespace Atv05.Repository
{
    public class CustomerRepository
    {
        public void Save (Customer customer)
        {
            DataSet.Customers.Add(customer);
        }

        public Customer Retrieve(int id)
        {
            foreach(var c in DataSet.Customers)
            {
                if( c.CustomerId == id )
                    return c;
            }

            return null;
        }
    }
}
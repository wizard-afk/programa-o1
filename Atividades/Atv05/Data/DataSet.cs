using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atv05.Models;

namespace Atv05.Data
{
    public static class DataSet
    {
        public static List<Address> Addresses { get; set; }
        public static List<Customer> Customers { get; set; }

        public static List<Product> Products { get; set; }
        public static List<Order> Orders { get; set; }
    }
}
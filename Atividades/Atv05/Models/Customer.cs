using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atv05.Models
{
    public class Customer
    {
        public int CustomerId {get; set;}
        public string Name {get; set;}
        public string EmailAddress {get; set;}
        public List<Address> Addresses { get; set; }
        public Customer()
        {

        }

        public Customer(int id)
        {
            CustomerId = id;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

        //erro nos dois retrieve
        public Customer Retrieve()
        {
            return new Customer();
        }

        public void Save(Customer customer)
        {

        }

    }
}
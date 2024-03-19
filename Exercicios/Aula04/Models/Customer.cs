using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04.Models
{
    public class Customer
    {
        public int CustumerId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime BirthDate {get; set;}
        public string EmailAddres {get; set;}

        //public Address Address1 {get; set;}
        //public Address Address2 {get; set;}
        public List<Address> Addresses = new List<Address>();

        public bool ValiDate()
        {
            return true;
        }
    }
}
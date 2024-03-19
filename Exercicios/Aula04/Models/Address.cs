using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula04.Models
{
    public class Address
    {
        public int AddressId {get; set;}
        public string Street {get; set;}
        public string District {get; set;}
        public int Number {get; set;}
        public string City {get; set;}
        public string FederalState {get; set;}
        public string Country {get; set;}
        public string ZipCode {get; set;}
        public AddresType AddresType {get; set;}
    }

    public enum AddresType // enumerador, enumerator, um mini tipo
    {
        Commercial, 
        Residential
    }
}
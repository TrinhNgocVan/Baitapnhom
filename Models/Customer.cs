using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapnhom.Models
{
    class Customer
    {
       
        private string name;
        private string address;
        private string phone;
        private string age;
        private string type;

        public Customer()
        {
        }

        public Customer(string name, string address, string phone, string age, string type)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Age = age;
            Type = type;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Age { get => age; set => age = value; }
        public string Type { get => type; set => type = value; }
    }
}

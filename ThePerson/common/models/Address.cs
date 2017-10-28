using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePerson {
    class Address {
        public string City { get; set; }
        public string Street { get; set; }
        public string Housing { get; set; }
        public string Home { get; set; }

        public Address() { }

        public Address(string city, string street, string housing, string home) {
            City = city;
            Street = street;
            Housing = housing;
            Home = home;
        }

        public Address(string city, string street) {
            City = city;
            Street = street;
        }

        public override string ToString() {
            return string.Format("Address city: {0}\nAddress street: {1}\nAddress housing: {2}\nAddress home: {3}", City, Street, Housing, Home);
        }
    }
}

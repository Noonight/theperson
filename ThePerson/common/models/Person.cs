using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePerson {
    class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string DateBirhday { get; set; }
        public Address LifePlace { get; set; }
        public Address BirthdayPlace { get; set; }
        public Document Document { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, string fatherName, string dateBirthday) {
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            DateBirhday = dateBirthday;
        }

        public Person(string firstName, string lastName, string fatherName, string dateBirthday, Address lifePlace, Address birthdayPlace, Document document) {
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            DateBirhday = dateBirthday;
            LifePlace = lifePlace;
            BirthdayPlace = birthdayPlace;
            Document = document;
        }

        public override string ToString() {
            return string.Format("Person: {0}, {1}, {2}\nDate Birthday: {3}", FirstName, LastName, FatherName, DateBirhday)
                + "\n" + LifePlace.ToString() + "\n" + BirthdayPlace.ToString() + "\n" + Document.ToString();
        }

    }
}

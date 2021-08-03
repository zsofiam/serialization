using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SerializePeople
{
    class Person
    {
        //Name(string), BirthDate(DateTime), Gender, (Genders enum) Age(int)
        private string name;
        private DateTime birthDate;
        private Gender gender;
        private int age;

        public Person(string name, DateTime birthDate, Gender gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
            age = DateTime.Now.Year - birthDate.Year;
        }

        public override string ToString()
        {
            return "Person: " + name + " " + age + " " + gender;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_information.Models
{
    public abstract class Person
    {
        public Person() { }
        public Person(string name, DateTime dob) //constructor overloading
        {
            this.Name = name;
            this.DOB = dob;
        }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public abstract int Age();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_information.Models
{
    public enum Designation { Manager, Assistant_Manager, Senior_Officer, Junior_Officer, Clerk }
    
        public sealed class Employee : Person
        {
            private List<string> roles = new List<string>();
            public Employee() { }
            public Employee(int id, string name, DateTime dob, Designation designation, double salary, DateTime joindate) : base(name, dob)
            {
                this.ID = id;
                this.Designation = designation;
                this.Salary = salary;
                this.JoinDate = joindate;
            }
            public int ID { get; set; }
            public Designation Designation { get; set; }
            public double Salary { get; set; }
            public DateTime JoinDate { get; set; }

            //public void AddRole(string aRole)
            //{
            //    this.roles.Add(aRole);
            //}

            //public void AddRoles(string rolesCsv)
            //{
            //    this.roles.AddRange(rolesCsv.Split(','));
            //}

            public override int Age()
            {
                return (DateTime.Now - DOB).Days / 365;
            }

            //public string RolePlay()
            //{
            //    return string.Join(",", this.roles.ToArray());
            //}
        }
}

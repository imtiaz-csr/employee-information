using employee_information.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_information
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ID=1,Name="Saiful Islam",DOB=new DateTime(1982,01,01),Designation=Designation.Junior_Officer,Salary=20000.00,JoinDate=new DateTime(2017,05,15)},
                new Employee{ID=2,Name="Shariful Islam",DOB=new DateTime(1992,05,01),Designation=Designation.Clerk,Salary=10000.00,JoinDate=new DateTime(2018,01,02)},
                new Employee{ID=3,Name="Rafiqul Islam",DOB=new DateTime(1994,01,20),Designation=Designation.Manager,Salary=40000.00,JoinDate=new DateTime(2016,01,02)},
                new Employee{ID=4,Name="Jahidul Islam",DOB=new DateTime(1995,05,01),Designation=Designation.Junior_Officer,Salary=20000.00,JoinDate=new DateTime(2018,05,15)},
                new Employee{ID=5,Name="Mustaq Ahmmed",DOB=new DateTime(1982,07,01),Designation=Designation.Assistant_Manager,Salary=30000.00,JoinDate=new DateTime(2015,12,20)},
                new Employee{ID=6,Name="Syed Ahmmed",DOB=new DateTime(1993,02,07),Designation=Designation.Senior_Officer,Salary=25000.00,JoinDate=new DateTime(2015,10,02)},
                new Employee{ID=7,Name="Sujan Khan",DOB=new DateTime(1995,08,01),Designation=Designation.Junior_Officer,Salary=20000.00,JoinDate=new DateTime(2019,04,05)},
                new Employee{ID=8,Name="Al-Amin",DOB=new DateTime(1990,10,01),Designation=Designation.Clerk,Salary=10000.00,JoinDate=new DateTime(2018,08,16)},
                new Employee{ID=9,Name="Ikbal Hossein",DOB=new DateTime(1985,10,01),Designation=Designation.Junior_Officer,Salary=20000.00,JoinDate=new DateTime(2018,09,13)},
                new Employee{ID=10,Name="Shahriar Shuvo",DOB=new DateTime(1987,08,01),Designation=Designation.Clerk,Salary=10000.00,JoinDate=new DateTime(2015,08,25)},
                new Employee{ID=11,Name="Gazi Selim",DOB=new DateTime(1990,07,01),Designation=Designation.Senior_Officer,Salary=25000.00,JoinDate=new DateTime(2015,06,05)},
                new Employee{ID=12,Name="Omar Sharif",DOB=new DateTime(1988,11,01),Designation=Designation.Junior_Officer,Salary=20000.00,JoinDate=new DateTime(2017,01,02)},
                new Employee{ID=13,Name="Navin-Ul-Haq",DOB=new DateTime(1990,09,15),Designation=Designation.Assistant_Manager,Salary=30000.00,JoinDate=new DateTime(2014,07,06)},
                new Employee{ID=14,Name="Ashraful Islam",DOB=new DateTime(1986,04,10),Designation=Designation.Junior_Officer,Salary=20000.00,JoinDate=new DateTime(2017,10,02)},
                new Employee{ID=15,Name="Ariful Islam",DOB=new DateTime(1988,12,25),Designation=Designation.Senior_Officer,Salary=25000.00,JoinDate=new DateTime(2020,02,20)},
                new Employee{ID=16,Name="Mehedi Hasan",DOB=new DateTime(1990,11,14),Designation=Designation.Junior_Officer,Salary=20000.00,JoinDate=new DateTime(2019,06,21)},
                new Employee{ID=17,Name="Monirul Islam",DOB=new DateTime(1994,10,14),Designation=Designation.Assistant_Manager,Salary=30000.00,JoinDate=new DateTime(2019,10,02)},
                new Employee{ID=18,Name="Atikul Islam",DOB=new DateTime(1992,05,25),Designation=Designation.Senior_Officer,Salary=25000.00,JoinDate=new DateTime(2016,06,15)},
                new Employee{ID=19,Name="Mohammed Tareq",DOB=new DateTime(1980,03,20),Designation=Designation.Manager,Salary=40000.00,JoinDate=new DateTime(2013,12,02)},
                new Employee{ID=20,Name="Imran Hossein",DOB=new DateTime(1992,04,22),Designation=Designation.Assistant_Manager,Salary=30000.00,JoinDate=new DateTime(2019,02,02)}
            };

            // Employee Details Show

            Console.WriteLine("1. Show Employees Informations\n");
            Console.WriteLine("\tName".PadRight(20, ' ') + "Designation".PadRight(20, ' ') + "Salary".PadRight(10, ' ') + "Joining Date".PadRight(30, ' ') + "Age");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            foreach (var e in employees)
            {
                Console.WriteLine($"\t{e.Name.PadRight(20, ' ')}{e.Designation.ToString().PadRight(20, ' ')}" +
                    $"{e.Salary.ToString().PadRight(10, ' ')}{e.JoinDate.ToString().PadRight(30, ' ')}{e.Age()}");
            }
            Console.WriteLine();

            // Filtering by Designation(Junior Officer)

            var FilterJuniorOfficer = employees.Where(x => x.Designation == Designation.Junior_Officer);
            Console.WriteLine("2. Filter by Designation(Junior Officer)\n");
            Console.WriteLine("\tName".PadRight(20, ' ') + "Designation".PadRight(20, ' ') + "Salary".PadRight(10, ' ') + "Joining Date".PadRight(30, ' ') + "Age");
            Console.WriteLine("\t------------------------------------------------------------------------------------------------------");
            foreach (var j in FilterJuniorOfficer)
            {
                Console.WriteLine($"\t{j.Name.PadRight(20, ' ')}{j.Designation.ToString().PadRight(20, ' ')}" +
                    $"{j.Salary.ToString().PadRight(10, ' ')}{j.JoinDate.ToString().PadRight(30, ' ')}{j.Age()}");
            }
            Console.WriteLine();

            // Order by Date of Birth(Ascending)

            var OrderbyDOB = employees.OrderBy(x => x.DOB);
            Console.WriteLine("3. Order by Date of Birth(Ascending)\n");
            Console.WriteLine("\tName".PadRight(20, ' ') + "Date of Birth".PadRight(30, ' ') + "Designation");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (var d in OrderbyDOB)
            {
                Console.WriteLine($"\t{d.Name.PadRight(20, ' ') }{d.DOB.ToString().PadRight(30, ' ')}{d.Designation}");
            }
            Console.WriteLine();

            // Group by Designation

            var groupDesignation = employees.GroupBy(x => x.Designation);
            Console.WriteLine("4. Group by Designation");
            Console.WriteLine("\tName".PadRight(20, ' ') + "Salary".PadRight(10, ' '));
            Console.WriteLine("\t---------------------------------------------------------------");
            foreach (var gkey in groupDesignation)
            {
                Console.WriteLine($"\n{gkey.Key}\n");
                foreach (var v in gkey)
                {
                    Console.WriteLine($"\t{v.Name.PadRight(20, ' ')}{v.Salary}");
                }
            }
            Console.WriteLine();

            // Filtering by Join Date Year(2017)

            var filteYear = employees.Where(x => x.JoinDate.Year == 2017);
            Console.WriteLine("5. Filter by Joining Year(2017)\n");
            Console.WriteLine("\tName".PadRight(20, ' ') + "Joining Date");
            Console.WriteLine("\t-------------------------------------------------");
            foreach (var Y in filteYear)
            {
                Console.WriteLine($"\t{Y.Name.PadRight(20, ' ')}{Y.JoinDate}");
            }
            Console.WriteLine();

            // Order by Descending (Salary)

            var DesSalary = employees.OrderByDescending(x => x.Salary);
            Console.WriteLine("6. Order by Higest Salary\n");
            Console.WriteLine("\tName".PadRight(20, ' ') + "Basic Salary");
            Console.WriteLine("\t--------------------------------------------");
            foreach (var s in DesSalary)
            {
                Console.WriteLine($"\t{s.Name.PadRight(20, ' ')}{s.Salary}");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

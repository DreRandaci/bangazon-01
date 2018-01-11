using System;
using System.Collections.Generic;

namespace bangazon_01
{
    class Program
    {
        static void Main(string[] args)
        {

            

            // Create some instances
            // Add derived departments to the list
            // HumanResources hr = new HumanResources("HR", "Amy Schumer", 2);
            // Development dev = new Development("Dev", "John Johnny", 2);
            // Marketing marketing = new Marketing("Marketing", "Bill Billy", 4);



            // Some departments get the base $75,000.00 budget, but others
            // will be adjusted up or down depending on the logic you wrote
            // in each class.
            // Iterate over all items in the list and output a string
            // representation of the class

            // double baseBudget = 75000.00;
            // foreach (Department d in departments)
            // {
            //     d.SetBudget(baseBudget);
            //     Console.WriteLine(d.getBudget());
            //     Console.WriteLine();
            //     Console.WriteLine($"{d.toString()}");                
            //     Console.WriteLine();
            // }

            // List<Employee> companions = new List<Employee>();
            // Employee dre = new Employee("Dre", "Randaci");
            // Employee jim = new Employee("Jim", "Randaci");
            // Employee brad = new Employee("Brad", "Randaci");
            // companions.Add(jim);
            // companions.Add(brad);
            // dre.eat();            
            // dre.eat("Crockpot Soup");            
            // dre.eat(companions);            
            // dre.eat("some goooooood shit", companions);   


            // In your Main method, create an instance of each of your Departments that you have defined. 
            // Then create two or three Employee instances for each `Department`, and add them to the appropriate `Department` instance.

            Development dev = new Development("Dev", "John Johnny", 3);
            Employee dre = new Employee("Dre", "Randaci");
            Employee jim = new Employee("Jim", "Jiminy");
            Employee brad = new Employee("Brad", "Bradly");
            dev.AddEmployee(dre);
            dev.AddEmployee(jim);
            dev.AddEmployee(brad);

            HumanResources hr = new HumanResources("HR", "Amy Schumer", 3);
            Employee sally = new Employee("Sally", "Salsbury");
            Employee bob = new Employee("Bob", "Evans");
            Employee jake = new Employee("Jake", "Cake");
            hr.AddEmployee(sally);
            hr.AddEmployee(bob);
            hr.AddEmployee(jake);

            Marketing marketing = new Marketing("Marketing", "Bill Billy", 2);
            Employee callan = new Employee("Callan", "Callansworth");
            Employee tanner = new Employee("Tanner", "Tannersworth");
            marketing.AddEmployee(callan);
            marketing.AddEmployee(tanner);
        
            List<Department> departments = new List<Department>();
            departments.Add(hr);
            departments.Add(dev);
            departments.Add(marketing);

            foreach (Department depart in departments)
            {
                Console.WriteLine($"Departmen: {depart._name}");
                foreach (Employee employee in depart.Employees) 
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);                    
                }
                Console.WriteLine();
            }
        }
    }
}



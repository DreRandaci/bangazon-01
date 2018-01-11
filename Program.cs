using System;
using System.Collections.Generic;

namespace bangazon_01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Department> departments = new List<Department>();

            // Create some instances
            // Add derived departments to the list
            HumanResources hr = new HumanResources("HR", "Amy Schumer", 2);
            Development dev = new Development("Dev", "John Johnny", 2);
            Marketing marketing = new Marketing("Marketing", "Bill Billy", 4);

            departments.Add(hr);
            departments.Add(dev);
            departments.Add(marketing);                                    

            // Some departments get the base $75,000.00 budget, but others
            // will be adjusted up or down depending on the logic you wrote
            // in each class.
            // Iterate over all items in the list and output a string
            // representation of the class

            double baseBudget = 75000.00;
            foreach (Department d in departments)
            {
                d.SetBudget(baseBudget);
                Console.WriteLine(d.getBudget());
                Console.WriteLine();
                Console.WriteLine($"{d.toString()}");                
                Console.WriteLine();
            }

            List<Employee> companions = new List<Employee>();
            Employee dre = new Employee("Dre", "Randaci");
            Employee jim = new Employee("Jim", "Randaci");
            Employee brad = new Employee("Brad", "Randaci");
            companions.Add(jim);
            companions.Add(brad);
            dre.eat();            
            dre.eat("Crockpot Soup");            
            dre.eat(companions);            
            dre.eat("some goooooood shit", companions);            

        }
    }
}



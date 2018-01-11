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
            HumanResources hr = new HumanResources("HR", "Amy Schumer", 2);
            Development dev = new Development("Dev", "John Johnny", 2);
            Marketing marketing = new Marketing("Marketing", "Bill Billy", 4);

            // Add derived departments to the list
            departments.Add(hr);
            departments.Add(dev);
            departments.Add(marketing);

            // Iterate over all items in the list and output a string
            // representation of the class
            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.toString()}");
                d.meet();
            }

            double baseBudget = 75000.00;

            // Some departments get the base $75,000.00 budget, but others
            // will be adjusted up or down depending on the logic you wrote
            // in each class.
            foreach (Department d in departments)
            {
                d.SetBudget(baseBudget);
                Console.WriteLine(d.getBudget());
                Console.WriteLine();
                Console.WriteLine($"{d.toString()}");                
                Console.WriteLine();
            }



        }
    }
}



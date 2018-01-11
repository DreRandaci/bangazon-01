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
            }
        }
    }
}



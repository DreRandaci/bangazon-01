using System;
using System.Collections.Generic;

namespace bangazon_01
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Create a method that allows external code to add an employee
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string pick_random_restaurant()
        {
            List<string> rando_restaurants = new List<string>()
            {
                "Mickey's",
                "Otaku",
                "M.L. Rose",
                "Miss Saigon"
            };
            Random rnd = new Random();
            int r = rnd.Next(rando_restaurants.Count);
            string selected_restaurant = rando_restaurants[r];
            return selected_restaurant; 
        }

        public void eat()
        {
            // select a random restaurant name from a list of strings, print to console that the employee is at that restaurant, and also return the restaurant.

            // Console.WriteLine($"{FirstName} {LastName} is at {this.pick_random_restaurant()}");
        }
        public void eat(string food)
        {
            // Will output that the employee ate that specific food at the office.
            // Console.WriteLine($"{FirstName} ate {food} at the office");

        }
        public void eat(List<Employee> companions)
        {
            // Will select a random restaurant name from a list of strings, print to console that the employee is at that restaurant, and also output the first name of each employee in the specified list.
            this.eat();
            foreach (Employee companion in companions)
            {
                Console.WriteLine($"{companion.FirstName} is also there");
            }

        }

        public void eat(string food, List<Employee> companions)
        {
            // Will select a random restaurant name from a list of strings, print to console that the employee at that restaurant, and ordered the specified food, with the first name of the teammates specified in the list.
            Console.WriteLine($"{FirstName} is at {this.pick_random_restaurant()} and ate {food}");
            this.eat(companions);
        }
    }
}
using System;
using System.Collections.Generic;

namespace bangazon_01
{
    public class Development : Department
    {
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        private string _meeting_place { get; set; } = "Coffee Shop";
        
        double Budget { get; set; } = 10000000000.00;

        public Development(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        {
        }

        public override void meet() 
        {
            Console.WriteLine(_meeting_place);
        }

        public override void SetBudget(double budget)
        {
            // The sales department needs more money than most others
            this.Budget += budget + 100000.00;
        }
        public override string getBudget()
        {
            return $"Budget: {this.Budget}";
        }
    }
}
using System;
using System.Collections.Generic;

namespace bangazon_01
{
    public class Sales : Department
    {
        public Sales(string name, string supervisor, int employees) : base(name, supervisor, employees)
        {
        }
        double Budget { get; set; }

        public string _meeting_place { get; set; } = "Somewhere with calculators";

        public override void meet()
        {
            Console.WriteLine(_meeting_place);
        }

        public override void SetBudget(double budget) => this.Budget += budget + 100000;
        public override string getBudget()
        {
            return $"Budget: {this.Budget}";
        }
    }
}
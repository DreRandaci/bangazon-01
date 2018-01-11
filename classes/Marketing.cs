using System;
using System.Collections.Generic;

namespace bangazon_01
{
    public class Marketing : Department
    {
        public string _meeting_place { get; set; } = "Somewhere with cool stuff on the walls";

        public Marketing(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        {
        }
        double Budget { get; set; } = 1231231.1231;

        public override void meet()
        {
            Console.WriteLine(_meeting_place);
        }        

        public override void SetBudget(double budget)
        {
            // The sales department needs more money than most others
            this.Budget += budget;
        }
        public override string getBudget()
        {
            return $"Budget: {this.Budget}";
        }
    }
}
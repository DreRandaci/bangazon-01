using System;

namespace bangazon_01
{
    // Parent class for all departments
    public class Department
    {
        private string _name;
        private string _supervisor;
        private int _employee_count;

        // You can create properties, if needed
        private string _metting_place { get; set; } = "Conference Room";

        private double Budget { get; set; }

        // Constructor method
        public Department(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
        }
        public string toString()
        {
            return $"Department: {_name}; Manager: {_supervisor}; Employee count: {_employee_count}";
        }
        public virtual void meet()
        {
            Console.WriteLine(_metting_place);
        }

        public virtual void SetBudget(double budget) => this.Budget += budget;

        public virtual string getBudget()
        {
            return $"Budget: {this.Budget}";
        }
    }
}
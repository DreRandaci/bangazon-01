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

        // Constructor method
        public Department(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
        }
        public string toString() 
        {
            return $"{_name} {_supervisor} {_employee_count}"; 
        }
    }
}
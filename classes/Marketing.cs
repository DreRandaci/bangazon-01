using System;
using System.Collections.Generic;

namespace bangazon_01
{
    public class Marketing : Department
    {
        private Dictionary<string, string> _policies = new Dictionary<string, string>();

        public Marketing(string dept_name, string supervisor, int employees) : base(dept_name, supervisor, employees)
        {
        }
    }
}
using System;
using System.Collections.Generic;

namespace UmlToCode
{
    public class Department
    {
        public List<Employee> Employed { get; set; }
        public Manager Manager { get; set; } 

        public Department()
        {
            Employed = new List<Employee>();
            Manager = null; 
        }

        public int CalculateWage()
        {
            int WagesBill = 0;
            foreach (var employee in Employed)
            {
                WagesBill += employee.Wage;
            }
            if (Manager != null)
            {
                WagesBill += Manager.Bonus;
            }
            return WagesBill;
        }
    }
}

using System;

namespace UmlToCode
{
    public class Manager : Employee
    {
        public int Bonus { get; set; }

        private int Salary { get; set; }

        public int GetSalary()
        {
            Salary = GetWage() + Bonus;
            return Salary;
        }
    }
}

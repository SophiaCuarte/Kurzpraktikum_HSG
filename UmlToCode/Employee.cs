using System;

namespace UmlToCode
{
    public class Employee

    {
        public string Name { get; set; }
        public int Wage { private get; set; }
        public int salary { get; set; }

        public int GetSalary(Manager manager)
        {
            manager.salary = Wage + manager.Bonus;
            return manager.salary;
        }

    }
}

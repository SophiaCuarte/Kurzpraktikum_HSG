using System;
using System.Collections.Generic;

namespace UmlToCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Felix";
            employee1.Wage = 100000;

            Manager manager1 = new Manager();
            manager1.Name = employee1.Name;
            manager1.Wage = employee1.Wage;
            manager1.Bonus = 3000;
            
            Department computer = new Department();
            computer.Employed.Add(employee1); 
            computer.Manager = manager1; 
            int WagesBill = computer.CalculateWage();

            Console.WriteLine("Unser bester Mitarbeiter ist " + employee1.Name + "!!");
            Console.WriteLine("Felix verdient einen grossen Happen im Monat, und zwar: " + manager1.salary);
            Console.WriteLine("Unsere Lohnkosten befinden sich bei " + WagesBill + " Franken im Monat");
        }
    }
}

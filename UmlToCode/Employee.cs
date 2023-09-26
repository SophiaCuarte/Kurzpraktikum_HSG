using System;

namespace UmlToCode
{
    public class Employee

    {
        public string Name { get; set; }
        public int Wage { private get; set; }

        public int GetWage()
        {
            return Wage;
        }

    }
}

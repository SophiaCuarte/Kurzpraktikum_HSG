using UmlToCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UmlToCode
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void GetWageTest()
        {
            int wage = 100;
            int bonus = 10;
            Manager manager = new Manager();
            Employee employee = new Employee(); 

            manager.Wage = wage;
            manager.Bonus = bonus;

            int expectedresult = 110;

            int result = manager.GetSalary();

            Assert.AreEqual(expectedresult, result);
        }
    }


    [TestClass]
    public class departmentTest
    {
        [TestMethod]
        public void CalculateWageTest()
        {
            int Wage = 10000;
            int bonus = 123;
            Employee Employee = new Employee();
            Manager manager = new Manager();
            Department department = new Department();

            department.Employed.Add(Employee);
            department.Manager = manager;

            Employee.Wage = Wage;
            manager.Bonus = bonus;

            int expectedresult = 10123;
            int result = department.CalculateWage();

            Assert.AreEqual(expectedresult, result);
        }
    }
}

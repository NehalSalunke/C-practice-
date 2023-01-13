using InheritanceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101,"john", "East India");
            //emp1.EmpId = 101;
            //emp1.EmpName = "John";
            //emp1.EmpLocation = "East India";

            Console.WriteLine("Object of parent class(Employee)");
            Console.WriteLine("Employee Id: " + emp1.EmpId);
            Console.WriteLine("Employee Name: " + emp1.EmpName);
            Console.WriteLine("Employee Location: " + emp1.EmpLocation);
            Console.WriteLine();

            // create object of manager class 
            Manager mgr1 = new Manager(102, "Mark Jhonson","South delhi","Accounts Department");
            //mgr1.EmpId = 102;
            //mgr1.EmpName = "Mark Johnson";
            //mgr1.EmpLocation = "South Delhi";
            //mgr1.DepartmentName = "Accounts Department";

            Console.WriteLine("Object of parent class(Employee)");
            Console.WriteLine("Employee Id: " + mgr1.EmpId);
            Console.WriteLine("Employee Name: " + mgr1.EmpName);
            Console.WriteLine("Employee Location: " + mgr1.EmpLocation);
            Console.WriteLine("Employee Department: " + mgr1.DepartmentName);
            Console.WriteLine("Full Department: " + mgr1.GetFullDepartmentName());
            Console.WriteLine("Employee total salary: " + mgr1.GetTotalSalesOfTheYear());
            Console.WriteLine("total health insurance" + mgr1.GetHealthInsuranceAmount());
            Console.WriteLine();

            // create object of Salesman class 
            Salesman sales1 = new Salesman(103, "Nehal Salunke","North Delhi","Noida");
            //sales1.EmpId = 103;
            //sales1.EmpName = "Nehal Ssalunke";
            //sales1.EmpLocation = "North Delhi";
            //sales1.Region = "Noida";

            Console.WriteLine("Object of parent class(Employee)");
            Console.WriteLine("Employee Id: " + sales1.EmpId);
            Console.WriteLine("Employee Name: " + sales1.EmpName);
            Console.WriteLine("Employee Location: " + sales1.EmpLocation); 
            Console.WriteLine("Employee region: " + sales1.Region);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

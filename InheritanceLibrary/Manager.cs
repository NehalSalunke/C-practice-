using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary
{
    public class Manager : Employee
    {
        // fields of Manager class
        private string _departmentName;

        public string DepartmentName { get => _departmentName; set => _departmentName = value; }

        public Manager(int empId, string empName, string empLocation, string departmentName) : base(empId, empName, empLocation)
        {
            this._departmentName = departmentName;
        }
        //method
        public long GetTotalSalesOfTheYear()
        {
            return 90000;
        }
        public string GetFullDepartmentName()
        {
            return DepartmentName + " at " + base.EmpLocation;
        }

        //virtual method 
        public sealed override string GetHealthInsuranceAmount()
        {
            Console.WriteLine(base.GetHealthInsuranceAmount());
                return "health insaurance iamount:"+ 25000;
        }
    }

}

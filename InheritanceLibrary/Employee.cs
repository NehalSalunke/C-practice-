using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary
{
    public class Employee
    {   // private fields
        private int _empId;
        private string _empName;
        private string _empLocation;

        //constructor
        public Employee(int empId, string empName, string empLocation)
        { 
            this._empId = empId;
            this._empName = empName;
            this._empLocation = empLocation;
        }

        public virtual string GetHealthInsuranceAmount()
        {
            return "health insaurance amount:" + 25000;
        }
        public int EmpId { get => _empId; set => _empId = value; }
        public string EmpName { get => _empName; set => _empName = value; }
        public string EmpLocation { get => _empLocation; set => _empLocation = value; }
    }
}

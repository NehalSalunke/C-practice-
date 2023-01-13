using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary
{
    public class Salesman : Employee
    {
        // ptivate fields
        private string _region;

        // constructor
        public Salesman(int empId, string empName, string empLocation, string region) : base(empId, empName,empLocation)
        {
            this._region = region;
        }
        public string Region { get => _region; set => _region = value; }

        public long GetSalesOfTheCurrentMonth()
        {
            return 15000;
        }
    }
}

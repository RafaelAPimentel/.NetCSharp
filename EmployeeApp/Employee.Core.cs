using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //Field Data
        private string empName;
        private int empAge;
        private int empID;
        private float currPay;
        private string empSNN;

        //Constructor
        public Employee() { }
        public Employee(string name, int id, float pay)
                : this(name, 0, id, pay, null) { }

        public Employee(string name, int age, int id, float pay, string snn)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            empSNN = snn;

        }
    }

    
}

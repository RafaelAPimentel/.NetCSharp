using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        //Field Data
        protected string empName;
        protected int empAge;
        protected int empID;
        protected float currPay;
        protected string empSNN;

        //Constructor
        public Employee() { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            currPay = pay;
        }

        public Employee(string name, int age, int id, float pay, string snn)
            : this(name, age, id, pay)
        {
            empSNN = snn;
        }
    }


}

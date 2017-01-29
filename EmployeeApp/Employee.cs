using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        //FIELD DATA
        private string empName;
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    WriteLine("Error ! Name length exceeds 15 characters");
                }
                else
                {
                    empName = value;
                }
            }
        }
        private int empAge;
        public int Age
        {

            get { return empAge; }
            set { empAge = value; }
        }
        private int empID;
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        private float currPay;
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }

        }
        private string empSNN;  
        public string SocialSecurityNumber
        {
            get { return empSNN; }
        }

        //Constructor
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay,null) { }

        public Employee(string name, int age, int id, float pay, string snn)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            empSNN = snn;

        }


        public void giveBonus(float amount)
        {
            WriteLine("Giving a bonus to {0} of value {1}", empName, amount);
            currPay += amount;

        }

        public void DisplayStats()
        {
            WriteLine("Name: {0}", empName);
            WriteLine("Age: {0}", empAge);
            WriteLine("ID: {0}", empID);
            WriteLine("Pay: {0}", currPay);
            WriteLine();
        }
    }
}

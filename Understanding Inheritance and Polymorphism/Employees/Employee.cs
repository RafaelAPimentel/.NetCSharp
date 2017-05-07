using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        public class BenifitPackage
        {
            public enum BenifitPackageLevel
            {
                Standard, Gold, Platnium
            }
            public double ComputePayDeduction()
            {
                return 125.5;
            }
        }
        public BenifitPackage empBenifits = new BenifitPackage();

        //Properties
        public BenifitPackage Benifits { get { return empBenifits; } set { empBenifits = value; } }
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

        public int Age { get { return empAge; } set { empAge = value; } }
        public int ID { get { return empID; } set { empID = value; } }
        public float Pay { get { return currPay; } set { currPay = value; } }
        public string SocialSecurityNumber { get { return empSNN; } }

        //Methods
        public double getBenifitsCost()
        {
            return empBenifits.ComputePayDeduction();
        }
        public virtual void giveBonus(float amount)
        {
            WriteLine("Giving a bonus to {0} of value {1}", empName, amount);
            currPay += amount;

        }

        public virtual void DisplayStats()
        {
            WriteLine("Name: {0}", empName);
            WriteLine("Age: {0}", empAge);
            WriteLine("ID: {0}", empID);
            WriteLine("Pay: {0}", currPay);
            WriteLine("SSN: {0}", empSNN);
        }
    }
}

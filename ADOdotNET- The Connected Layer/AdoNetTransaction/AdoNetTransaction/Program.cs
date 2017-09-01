using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using AutoLotDAL.ConnectedLayer;
using System.Configuration;

namespace AdoNetTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("**** Simple transaction example ****\n");

            //a a simple way to allow the tx to succeed or not
            bool throwEx = true;

            Write("Do you want to throw an exception (Y or N): " );
            var userAnswer = ReadLine();
            if (userAnswer?.ToLower() == "n")
            {
                throwEx = false;
            }

            var dal = new InventoryDAL();
            dal.OpenConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString.ToString());

            //process customer homer enter the id for homer simpson in the next line
            dal.ProcessCreditRisk(throwEx, 9);
            WriteLine("Check CreditRisk table for results");
            ReadLine();
        }
    }
}

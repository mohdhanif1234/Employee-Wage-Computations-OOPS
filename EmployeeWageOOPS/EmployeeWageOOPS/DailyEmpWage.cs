using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class DailyEmpWage
    {
        // Constants
        public const int IS_FULL_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;

        public static void DailyEmpWageCalculation()
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            // Computation
            int empCheck = random.Next(0, 2);

            // Getting employee work hours
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            } 
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : Rs " + empWage);
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            DailyEmpWageCalculation(); // Method calling to calculate daily employee wage
        }
    }
}

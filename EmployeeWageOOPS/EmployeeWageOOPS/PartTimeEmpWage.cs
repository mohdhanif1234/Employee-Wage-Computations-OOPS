using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class PartTimeEmpWage
    {

        // UC-4: Calculating part time employee wage using switch case

        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR= 20;

        public static void PartTimeEmpWageCalculation()
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            // Computation
            int empCheck = random.Next(0, 3);

            // Getting employee work hours
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : Rs " + empWage);
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            PartTimeEmpWageCalculation(); // Method calling to calculate part time employee wage
        }
    }
}

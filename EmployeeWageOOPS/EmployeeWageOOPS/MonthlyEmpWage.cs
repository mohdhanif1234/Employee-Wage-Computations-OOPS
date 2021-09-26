using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class MonthlyEmpWage
    {

        // UC-5: Calculating monthly employee wage assuming 20 working days in a month 

        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR= 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        public static void MonthlyEmpWageCalculation()
        {
            // Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            // Computation
            Random random = new Random();
            for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
            {
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
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage for day " + day + " : Rs " + empWage);
            }

            // Calculating total employee wage for a month
            Console.WriteLine("Total Emp Wage : Rs " + totalEmpWage);
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            MonthlyEmpWageCalculation(); // Method calling to calculate monthly employee wage
        }
    }
}

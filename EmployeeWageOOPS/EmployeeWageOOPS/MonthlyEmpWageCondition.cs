using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class MonthlyEmpWageCondition
    {

        /* UC-6: Calculating monthly employee wage till a condition of either the max working hours or 
          max number of working days is reached, assuming 20 working days in a month */ 

        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR= 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 50;

        public static void MonthlyEmpWageCond()
        {
            // Variables
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            // Computation
            Random random = new Random();
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);
                
                // Getting employee hours 
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day {0}: Emp Hrs : {1}",totalWorkingDays,empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : Rs " + totalEmpWage);
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            MonthlyEmpWageCond(); // Method calling to calculate monthly employee wage till a condition is meet
        }
    }
}

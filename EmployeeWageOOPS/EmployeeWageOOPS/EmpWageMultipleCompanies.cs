using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class EmpWageMultipleCompanies
    {
        //UC-8: Ability to calculate employee wage for multiple companies  

        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingdays = 0;

            Random random = new Random();
            // Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingdays < numOfWorkingDays)
            {
                totalWorkingdays++;
                int empCheck = random.Next(0, 3);
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
                Console.WriteLine("Day {0}: Emp Hrs : {1}",totalWorkingdays,empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {
            ComputeEmpWage("DMart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);
            Console.ReadLine();
        }
    }
}

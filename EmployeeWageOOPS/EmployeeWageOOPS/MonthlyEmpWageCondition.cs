using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class MonthlyEmpWageCondition
    {
        //UC-7: Refactor the code to include the class methods  

        // Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;

        public static int ClassMethodToComputeEmpWage()
        {
            // Declaring and initializing local variables
            int empHr;
            int day = 1;
            int totalWorkHr = 0;

            Random random = new Random();
            // Computation
            while (day <= MAX_WORKING_DAYS && totalWorkHr <= MAX_WORKING_HOURS)
            { 
                int empCheck = random.Next(0, 3);

                // Getting employee work hours
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                day++;
                int dailyWage = EMP_RATE_PER_HOUR * empHr;
                Console.WriteLine("Daily wage is " + dailyWage);
                totalWorkHr += empHr;
            }
            return totalWorkHr;
        }

        static void Main(string[] args)
        {
            int totalWorkHr = ClassMethodToComputeEmpWage(); // Method calling to get the total employee wage
            int totalWage = EMP_RATE_PER_HOUR * totalWorkHr;
            Console.WriteLine("Total wage is : Rs " + totalWage);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class EmpWageBuilderObject
    {
        //UC-9: Ability to compute employee wage and save total wage by company  

        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        // Declaring the required variables
        string company;
        int empRatePerHour, numOfWorkingDays, maxHoursPerMonth, totalEmpWage;

        // Constructor to initialize the declared variables
        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeEmpWage()
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            // Computation
            Random random = new Random();
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);

                // Getting employee work hours
                switch(empCheck)
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
                totalEmpWage = totalEmpHrs * this.empRatePerHour;
            }
        }
        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is: Rs " + this.totalEmpWage;
        }
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.ComputeEmpWage(); // Method calling to get the employee wage for DMart company
            Console.WriteLine(dMart.toString()); 
            reliance.ComputeEmpWage(); // Method calling to get the employee wage for Reliance company
            Console.WriteLine(reliance.toString());
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class EmpWageBuilderArray
    {
        //UC-10: Ability to compute employee wage of multiple companies and manage it using arrays  
        public const int fullTimePresent = 1;
        public const int partTimePresent = 2;
        public int numOfCompany = 0;
        public CompanyEmpWage[] companyEmpWagesArray;

        //Declare a constructor to create  object of that type
        public EmpWageBuilderArray()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }

        //store the object of the class for each company inside array
        public void addCompanyWage(string companyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            companyEmpWagesArray[this.numOfCompany] = new CompanyEmpWage(companyName, empRatePerHr, maxWorkingDays, maxWorkingHrs);
            numOfCompany++;
        }

        public void computeEmpWageofEachCompany()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWagesArray[i].setTotalWage(this.computeEmpWageofEachCompany(this.companyEmpWagesArray[i]));
                Console.WriteLine(companyEmpWagesArray[i].toShowWage());
            }
        }
        public int computeEmpWageofEachCompany(CompanyEmpWage companyEmpWage)
        {
            //Declare variable
            int empHr = 0;
            int day = 1;
            int totalWorkHr = 0;

            //Compute emp wage
            while (day <= companyEmpWage.maxWorkingDays && totalWorkHr <= companyEmpWage.maxWorkingHrs)
            {
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case fullTimePresent:
                        empHr = 8;
                        break;
                    case partTimePresent:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                day++;

                // Calculate total work hour
                totalWorkHr += empHr;
            }

            // Return total wage of that given comapany
            return totalWorkHr * companyEmpWage.empRatePerHr;
        }
            static void Main(string[] args)
        {
            Console.Write("Enter number of companies: ");
            int numOfCompany = Convert.ToInt32(Console.ReadLine());
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            for (int i = 0; i < numOfCompany; i++)
            {
                Console.Write("Enter the company name: ");
                string companyName = Console.ReadLine();
                Console.Write("Enter emp rate per hour of the company: Rs ");
                int empRatePerHr = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter max working days of the company: ");
                int maxWorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter max working hours of company: ");
                int maxWorkingHrs = Convert.ToInt32(Console.ReadLine());
                empWageBuilderArray.addCompanyWage(companyName, empRatePerHr, maxWorkingDays, maxWorkingHrs);
            }

            //Calling each company to compute separate total wage
            empWageBuilderArray.computeEmpWageofEachCompany();
            Console.ReadLine();
        }
    }
}

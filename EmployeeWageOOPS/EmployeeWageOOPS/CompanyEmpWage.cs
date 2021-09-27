using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class CompanyEmpWage
    {
        //Declare instance of this class
        public string companyName;
        public int empRatePerHr;
        public int maxWorkingDays;
        public int maxWorkingHrs;
        public int totalEmpWage;

        //Declare a constructor to create  object of that type
        public CompanyEmpWage(string companyName, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.companyName = companyName;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }

        // To set total emp wage
        public void setTotalWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        //return total emp wage
        public string toShowWage()
        {
            return "Total emp wage of " + this.companyName + " company is: Rs " + this.totalEmpWage;
        }
    }
}

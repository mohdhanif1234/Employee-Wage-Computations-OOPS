using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    class EmpAttend
    {
        // Constants
        public const int IS_FULL_TIME = 1;

        public static void EmployeeAttendanceCheck() // Method to check the employee attendance
        {
            Random random = new Random();

            // Computation
            int empAttendanceCheck = random.Next(0, 2);
            if (empAttendanceCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            EmployeeAttendanceCheck(); // Method calling
        }
    }
}

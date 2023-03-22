using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageConstructor
{
    public class EmployeeWageUC3
    {
        int Is_Present_Full_Time, Is_Present_Part_Time, Is_Absent, Total_Wage, wage_per_hour, num,EmpHrs;
        
        public EmployeeWageUC3()
        {
            Is_Present_Full_Time = 1;
            Is_Present_Part_Time = 2;
            Is_Absent = 0;
            Total_Wage = 0;
            wage_per_hour = 20;
            EmpHrs = 0;

            Random random = new Random();
            int num = random.Next(3);

            if (num == 0)
            {
                EmpHrs = 0;
                Console.WriteLine("Employee is Absent");

            }
            else if(num ==1)
            {
                EmpHrs = 8;
                Console.WriteLine("Employee is present for full time");
            }
            else
            {
                EmpHrs = 4;
                Console.WriteLine("Employee is present for part time");
            }
            Total_Wage = EmpHrs * wage_per_hour;

            Console.WriteLine("TotaL Wage is = " + Total_Wage);

        }
    }
}

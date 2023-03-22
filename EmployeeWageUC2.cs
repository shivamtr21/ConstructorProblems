using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageConstructor
{
    public class EmployeeWageUC2
    {
        int Is_Present, Is_Not_Present, num,wage_per_hour,EmpHrs,Total_Wage;

        public EmployeeWageUC2()
        {
            EmpHrs = 0;
            Total_Wage = 0;
            wage_per_hour = 20;

            Random random = new Random();
            int num = random.Next(2);

            if (num == 1)
            {
                EmpHrs = 8;
            }
            else
            {
                EmpHrs = 0;
            }
            Total_Wage = EmpHrs * wage_per_hour;
            Console.WriteLine("Total Wage is = "+ Total_Wage);

        }
    }
}

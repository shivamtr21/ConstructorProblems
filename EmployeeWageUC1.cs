using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageConstructor
{
    public class EmployeeWageUC1

    {
        int Is_Present, Is_Not_Present,num;
        public EmployeeWageUC1()

        {
            Is_Present = 1;
            Is_Not_Present = 0;
            Random random = new Random();
            int num = random.Next(2);


            if(num == 1)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
            
            
        }
    }
}

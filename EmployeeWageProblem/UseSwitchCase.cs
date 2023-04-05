using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class UseSwitchCase
    {
        public static void SwitchCase()
        {
            int Emp_Rate_Per_Hour = 20;
            int Empwage;
            int Emphours;

            Random random = new Random();
            int empcheck = random.Next(3);


            switch (empcheck)
            {
                case 0:
                    Emphours = 8;
                    Console.WriteLine("Employee is full time");
                    break;

                case 1:
                    Emphours = 4;
                    Console.WriteLine("Employee is part time");
                    break;

                default:
                    Emphours = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }

            Empwage = Emphours * Emp_Rate_Per_Hour;
            Console.WriteLine("Daily employee wage is : " + Empwage);

        }
    }
}

    


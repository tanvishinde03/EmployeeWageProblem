﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class PartTimeEmpWage
    {
        public static void PartTime()
        {
            int Is_Full_Time = 1;
        int Emp_Rate_Per_Hour = 20;
        int Is_Part_Time = 2;
        int Empwage;
        int Emphours;

        Random random = new Random();
        int empcheck = random.Next(3);
            if (empcheck == Is_Full_Time)
            {
                Emphours = 8;
                Console.WriteLine("Employee is present");
            }
            else if (empcheck == Is_Part_Time)
            {
                Emphours = 4;
                Console.WriteLine("Employee is present for part time");
            }
                        else
             {
                Emphours = 0;
                Console.WriteLine("Employee is absent");
            }
            Empwage = Emphours * Emp_Rate_Per_Hour;
            Console.WriteLine("Daily employee wage is : " + Empwage);
                    }
                }
            }
    


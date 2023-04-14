using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CheckAttendance checkattendance = new CheckAttendance();  //UC1
            //checkattendance.Attendance();
            //Console.ReadLine();

            //DailyEmpWage dailyempwage = new DailyEmpWage();  //UC2
            //DailyEmpWage.EmpWage();
            //Console.ReadLine();

            //PartTimeEmpWage parttimeemp = new PartTimeEmpWage();  //UC3
            //PartTimeEmpWage.PartTime();
            //Console.ReadLine();

            //UseSwitchCase switchcase= new UseSwitchCase();   //UC4
            //UseSwitchCase.SwitchCase();
            //Console.ReadLine();

            //MonthlyWage monthlyWage= new MonthlyWage();   //UC5
            //MonthlyWage.EmployeeMonthlyWage();
            //Console.ReadLine();

            //TotalDaysHours totalDaysHours = new TotalDaysHours();  //UC6
            //TotalDaysHours.DaysHoursOfMonth();
            //Console.ReadLine();

            RefectorCode obJ = new RefectorCode();    //UC7
            RefectorCode.ComputeEmpWage();
            Console.ReadLine();
        }
    }
}

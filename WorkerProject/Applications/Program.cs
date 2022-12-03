using System;
using System.Collections.Generic;
using System.Globalization;
using WorkerProject.Entities;
using WorkerProject.Entities.Enuns;

namespace WorkerProject.Applications
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.Write(" Enter your Department... ");
            string department = Console.ReadLine();

            Department dp = new Department(department);

            Console.Write(" Enter your name... ");
            string name = Console.ReadLine();

            Console.Write(" Enter your Worker Level Junior/MidLevel or Senior ?... ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine().ToUpper());

            Console.Write(" Enter your base salary $ ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, dp, level, baseSalary);
            Console.Write(" How many contracts do you have? ... ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                

                Console.Write(" Enter with " + i + "° Date  ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write(" Value per hour $ ... ");
                double valurPerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write(" Duration ... ");
                int duration = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date, duration, valurPerHour);
                worker.AddContract(hourContract);

            }



    
            Console.WriteLine("\n");

            Console.Write(" Enter with month and year for calculate income  (MM/YEAR): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine(worker.ToString());
            Console.WriteLine( " Income for " + month+"/"+year+ " $ " + worker.Income(month, year).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("\n");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int answer = Add(a, b);
            //Console.WriteLine(answer);

            Console.WriteLine("Please input name.");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("Please input favorite food.");
            string food = Console.ReadLine().Trim();
            FavoriteFood(name, food);
            RetirementCalculator(28);
            Console.WriteLine(WageCalculator(23.43, 32.43));
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        public static void FavoriteFood(string name, string food)
        {
            Console.WriteLine("{0}'s favorite food is {1}.", name, food);
        }

        public static void RetirementCalculator(int userAge)
        {
            int retirement = 65 - userAge;
            Console.WriteLine("The user will retire in {0} years.", retirement);
        }

        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            double weekSalary = hoursWorked * hourlyWage;
            return weekSalary;
        }
    }
}

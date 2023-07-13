using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        enum Seasons {
            winter,
            summer,
            rainy
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first number");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2=int.Parse(Console.ReadLine());
            var result = num1 > num2 ? "First number is greater" : "Second number is greater";
            Console.WriteLine(result);

            Console.WriteLine("Current Season is: " + Seasons.rainy);
            Console.WriteLine("Season Number is: " + (int)Seasons.rainy);
            Console.ReadKey();
        }
    }
}

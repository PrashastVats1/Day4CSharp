using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pre, final;
            Console.WriteLine("Enter the Pre Marks");
            pre = int.Parse(Console.ReadLine());
            if (pre > 60)
            {
                Console.WriteLine("Enter the Final Marks");
                final = int.Parse(Console.ReadLine());
                if (final > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Failed in Final");
                }
            }
            else
            {
                Console.WriteLine("Failed in Pre");
            }
            Console.ReadKey();
        }
    }
}

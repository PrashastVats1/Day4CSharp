using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 4
            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());
            //if(num>0 )
            //{
            //    Console.WriteLine("The Number is Positive");
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine("The Number is Negative");
            //}
            //else
            //{
            //    Console.WriteLine("The Number is Zero");
            //}
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("The Number is Even");
            //}
            //else
            //{
            //    Console.WriteLine("The Number is Odd");
            //}

            //Assignment 5
            int attempts = 0;
            string correctName = "Prashast";
            string correctPwd = "1234567890";
            while (attempts < 3)
            {
                Console.Write("Enter Username: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                if (userName == correctName && password == correctPwd)
                {
                    Console.WriteLine("Login Successful!!");
                    break;
                }
                else if (userName == correctName)
                {
                    Console.WriteLine("Invalid Password");
                }
                else
                {
                    Console.WriteLine("Invalid Username");
                }
                attempts++;
            }
            if (attempts >= 3) {
                Console.WriteLine("Login Failed");
            }
            Console.ReadKey();
        }
    }
}

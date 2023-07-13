using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] marks = new int[5];
            //for(int i = 0; i<5; i++){
            //    Console.WriteLine("Enter Marks in Subject " +(i+1));
            //    marks[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Subject {1+1}:\t Marks: {marks[i]}");
            //}
            ////other ways to declare an array
            //int[] marks1 = { 12, 23, 34, 56, 69 };
            //int[] marks2 = new int[5] { 12, 23, 34, 56, 69 };
            Console.WriteLine("Enter Number of Students");
            int nos = int.Parse(Console.ReadLine());
            string[] students = new string[nos];
            for(int i = 0; i < nos; i++)
            {
                Console.WriteLine($"Enter Student {i+1}\'s name");
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("List of Students");
            foreach(string student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }
}

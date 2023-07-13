using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[,] myRectArray = new string[4, 3];
            //for(int i = 0; i < myRectArray.GetLength(0); i++)
            //{
            //    for(int j = 0; j < myRectArray.GetLength(1); j++)
            //    {
            //        myRectArray[i,j] = "["+i + "," + j + "]";
            //    }
            //}
            //Console.WriteLine("Stored Values are:");
            //for (int i = 0; i < myRectArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myRectArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine(myRectArray[i,j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            int[,] marks = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter Student {i + 1}\'s Roll Number");
                marks[i, 0] = int.Parse(Console.ReadLine());
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter Marks of Student{i + 1}\'s in Sem {j}");
                    marks[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Marks List is as follows");
            Console.WriteLine("Roll No. Sem 1\t Sem 2");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(marks[i, j] + "       \t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise_2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] studMarks = new int[4, 5];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter RollNo for Student {i+1}: ");
                studMarks[i, 0] = int.Parse(Console.ReadLine());

                for (int j = 1; j < 5; j++)
                {
                    Console.WriteLine($"Enter Marks of Student{i + 1}\'s in Sem {j}");
                    studMarks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Marks List is as follows");
            Console.WriteLine("RollNo\tSem1\tSem2\tSem3\tSem4\tTotal");
            for (int i = 0; i < 4; i++)
            {
                int totalMarks = 0;
                Console.Write(studMarks[i, 0] + "\t");
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(studMarks[i, j] + "\t");
                    totalMarks += studMarks[i, j];
                }

                Console.WriteLine(totalMarks);
            }

            Console.ReadKey();
            /*
             * Console.WriteLine("Marks List is as follows");
             * Console.WriteLine($"Enter Marks of Student{i + 1}\'s in Sem {j+1}");
             */
        }
    }
}

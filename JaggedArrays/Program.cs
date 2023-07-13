using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] myJArray = new int[3][];
            myJArray[0] = new int[3] { 12, 11, 13 };
            myJArray[1] = new int[5] { 10, 14, 16, 87, 69 };
            myJArray[2] = new int[2] { 10, 63 };
            Console.WriteLine("\n");
            for (int i = 0; i < myJArray.Length; i++)
            {
                for(int j = 0; j < myJArray[i].Length; j++)
                {
                    Console.Write(myJArray[i][j]+"\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

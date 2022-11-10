using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic5day
{
    class basic6
    {
        static void Main(string[] args)
        {
            int[][] a = new int[][] { new int[] { 0, 1 }, new int[] { 2 }, new int[] { 3, 4, 5, 6 } };

            for(int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

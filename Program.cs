using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourGlass_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            //use the following for input
            //1 1 1 0 0 0
            //0 1 0 0 0 0
            //1 1 1 0 0 0
            //0 0 2 4 4 0
            //0 0 0 2 0 0
            //0 0 1 2 4 0

            int maxSum = -64;
            int sumTotal;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j + 2 < 6 && i + 2 <6)
                    {
                        // First Line
                        sumTotal = arr[i][j] + arr[i][j+1] + arr[i][j+2]
                        // Second Line
                                        + arr[i+1][j+1] +
                        // Third Line
                        arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];

                        if (sumTotal > maxSum)
                        {
                            maxSum = sumTotal;
                        }
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}

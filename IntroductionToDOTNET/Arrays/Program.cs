#define SINGLE_DIMESIONAL_ARRAYS
#define MYLTI_DIMESIONAL_ARRAYS
#define JAGGED_DIMESIONAL_ARRAYS


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
#if SINGLE_DIMESIONAL_ARRAYS
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 500);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            foreach (var i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

#endif
        }
    }
}

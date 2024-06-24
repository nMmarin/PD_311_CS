using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Recursion
    {

        static void Main(string[] args)
        {
            //    Console.Write("Введите номер этажа: ");
            //    int floor = Convert.ToInt32(Console.ReadLine());
            //    Elevator(floor);
            Console.Write("Введите чисо: ");
            int n = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine($"\n----------------\n{n}!={Factorial(n)}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.GetType()}:{ex.Message}");
            }
            
        }


        static void Elevator(int floor)
        {
            if (floor == 0)
            {
                Console.WriteLine("Вы в подвале");
                return;
            }
            Console.WriteLine($"Вы на  {floor}");
            Elevator(floor - 1);
            Console.WriteLine($"Вы на  {floor}");

        }

        static long Factorial(long n)
        {
            if (n == 0) return 1;
            long f = n * Factorial(n - 1);
            Console.WriteLine($"{n}!={f}");

            return f;
        }
       
    }
   
}
 
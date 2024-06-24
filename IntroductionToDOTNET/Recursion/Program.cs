using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Recursion
{
    class Recursion
    {

        static void Main(string[] args)
        {
            //    Console.Write("Введите номер этажа: ");
            //    int floor = Convert.ToInt32(Console.ReadLine());
            //    Elevator(floor);
            //Console.Write("Введите чисо: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    DateTime start = DateTime.Now;

            //    Console.WriteLine($"\n----------------\n{n}!={Factorial(n)}");
            //    DateTime end = DateTime.Now;
            //    TimeSpan duration = end - start;
            //    Console.WriteLine($"Duration:{duration.ToString("g")}");
            //}
            //catch(StackOverflowException ex)
            //{
            //    Console.WriteLine($"{ex.GetType()}:{ex.Message}");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"{ex.GetType()}:{ex.Message}");
            //}

            Console.Write("Введите основание степени: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите показатель степени: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Power(a, n));
            Main(args);

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

        static BigInteger Factorial(long n)
        {
            BigInteger f = 1;
            for (int i = 1; i < n; i++)
            {
                f *= i;
            }
            return f;
            //if (n == 0) return 1;
            //try
            //{
            //    BigInteger f = n * Factorial(n - 1);
            //    //Console.WriteLine($"{n}!={f}");
            //    return f;
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}




        }
        static double Power(double a, int n)
        {
            return n == 0 ? 1 : n > 0 ? a * Power(a, n - 1) : 1 / Power(a, -n);
            //    if (n == 0) return 1;
            //    else if (n>0)
            //    {
            //        return a* Power(a,n - 1);
            //    }
            //    else
            //    {
            //        return 1 / Power(a,-n); 
            //    }
            //}

        }
    }
   
}
 
using System;

namespace meth
{
    class Program
    {
        static int fack(int m)
        {
            int res=1;
            for (int i=1; i <=m;i++)
            {
                res *= i;
            }
            return res;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int f1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите к");
            int f2 = Convert.ToInt32(Console.ReadLine());
            int n = fack(f1);
            int k = fack(f2);
            int sd = fack(f1 - f2);
            int c = n / (sd * k);
            Console.WriteLine("результат"+c);

        }
    }
}

using System;

namespace PolindiromNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num= 121;
            int temp = num;
            int sum = 0;
            int q;

            while(num>0)
            {
                q = num % 10;
                num = num / 10;
                sum = sum * 10 + q;
            }
             if (temp==sum)
            {
                Console.WriteLine("polindirom ededdir");
            }
            else
            {
                Console.WriteLine("polindirom eded deyil");
            }
        }
    }
}

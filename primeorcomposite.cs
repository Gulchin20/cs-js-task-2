using System;

namespace PrimeOrComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 113;
            int q;
            int i=2;
            bool t = true;
            while(i<num)
            {
                q = num % i;
               if( q == 0)
                {
                    t = false;
                    Console.WriteLine("murekkeb ededdir");
                    break;
                }
                i++;
                
            }
            if (t)
            {
                Console.WriteLine("sade ededdir");
            }
                
        }
    }
}

using System;

namespace PowerOf2
{       
    class Program
    {
        static void Main(string[] args)
        {
           int num=24;
           int q ;
            bool p = true;
            while (num>=2 )
            {
               
                q=num % 2;
                num = num / 2;
                if (q!=0)
                {
                    p = false;
                    Console.WriteLine("2 nin quvveti deyil");
                    break;
                }
        
               
            }
            if(p)
            {
                Console.WriteLine("2 nin quvvetidir");
            }
        }
    }
}

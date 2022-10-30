using System;

namespace Month
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 3;
            switch(month)
            {
                case 12:
                case 1:
                case 2:
                  Console.WriteLine("qis fesli");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("yaz fesli");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yay fesli");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("payiz fesli");
                    break;
                default:
                    Console.WriteLine("wrong");
                    break;
            }
        }
    }
}

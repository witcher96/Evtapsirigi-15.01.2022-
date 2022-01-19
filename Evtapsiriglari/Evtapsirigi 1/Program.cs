using System;

namespace Evtapsirigi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a= 73;

            if ((a %= 2) > 0){
                Console.WriteLine("Tekdir");
                Console.ReadKey();
   
            }
            else
            {
                Console.WriteLine("Cutdur");
                Console.ReadKey();
            }
        }
    }
}

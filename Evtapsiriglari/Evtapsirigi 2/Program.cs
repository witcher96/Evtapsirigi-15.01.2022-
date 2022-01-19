using System;

namespace Evtapsirigi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 213;

         
            if ((a %=4)==0)
            {
                Console.WriteLine("Bolunur");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Bolunmur");
                Console.ReadKey();
            }
        }
    }
}

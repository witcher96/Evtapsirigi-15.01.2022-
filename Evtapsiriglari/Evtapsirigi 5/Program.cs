using System;

namespace Evtapsirigi_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int a = 1; a<=50; a++)
            {
             if (((a % 3) ==0) || ((a % 5) == 0))
             {
                 Console.WriteLine(a);
             }        
            }
        }
    }
}

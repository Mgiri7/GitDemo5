using System;

// Main method
namespace Demo
{
    class Program
    {
       static void Main()
        {
            int a = 10;
            int z=20;
            int? b = null;
            int? c = 100;

            Console.WriteLine(a);
            Console.WriteLine(z);
            Console.WriteLine(b);

            int k = b?? 0;
            Console.WriteLine(k);
            int y = c ?? 0;
            Console.WriteLine(y);
        }
    }
}

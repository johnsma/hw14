using System;

namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 90;
            string hello = "How are you?";
            float y = 5.5f;
            double x = 5.4;
            bool be = false;
            //print each line
            Console.WriteLine(max);
            Console.WriteLine(hello);
            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.WriteLine(be);
           

            //interpulation
            Console.WriteLine("Hello {0} I am {1} tall and my grandmother is over {2}", hello, x, max);
            
            //user input
            Console.Write("Enter your address:..");
            string address = Console.ReadLine();
            Console.WriteLine(address);
            //two false
            Console.WriteLine("ten" == "nine");
            Console.WriteLine(-1 > 2);
            //two true
            Console.WriteLine(5 < 10);
            Console.WriteLine("one" == "one");
            Console.ReadKey();
        }
    }
}

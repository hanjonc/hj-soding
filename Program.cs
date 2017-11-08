using System;

namespace ConsoleApp1
{

    class Program
    {
        public static int Fib(int x)
        {
            int num = 0;
            int num2 = 1;
            int fibonacci = 0;

            if (x == 0)
            {
                return 0;
            }

            else if (x == 1)
            {
                return 1;
            }


            else
            {
                for (int i = 1; i <= x; i++)
                {
                    fibonacci = num + num2;
                    num = num2;
                    num2 = fibonacci;
                }
                return fibonacci;
            }
            
        }
        public static void Main(string[] args)
        {
            int fibo = 0;
            int even = 0;

            for (int i = 1; i < 33; i++)
            {
                fibo = Fib(i);
                if (fibo % 2 == 0)
                {
                    even += fibo;
                }
                
                Console.Write("{0} ", fibo);
                

            }
            Console.Write("\n\nSum of even-valued terms: " + even);
            Console.ReadKey();
        }
    }

}

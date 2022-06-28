using System;

namespace Methods6._27._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(1, 8);
                if (result > 10)
            {
                Console.WriteLine("Result is larger than 10!");
            }

            else
            {
             Console.WriteLine("Result is smaller than or equal to 10!");
            }
                
            Console.ReadKey();
        }

        public static int Add (int num01, int num02)
        {
            return num01 + num02;

        }

        
    }
}

using System;

namespace Factorial
{
   class program
   {
        
        public static double Factorial(int val)
        {
            if(val == 0 || val ==1)
            {
                return 1;
            }
            else
            {
                return val * Factorial(val - 1);
            }
        }
        
        
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Introduzca el numero:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Su Factorial de {0} es: {1}",num, Factorial(num));
            Console.ReadKey();

        }
   }
}
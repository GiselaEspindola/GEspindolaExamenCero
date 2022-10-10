using System;

namespace SopaLetras
{
    class program
    {

        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Ingresa la Palabra:");
            str = Console.ReadLine();
            orden(str);
        }
        static void orden(string str)
        {
            str= String.Concat(str.OrderBy(ch => ch));
            Console.Write(str);
        }
    }
}
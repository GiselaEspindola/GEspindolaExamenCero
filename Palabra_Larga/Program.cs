using Microsoft.VisualBasic;
using System;

namespace Palabra_Larga
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encontrar la palabra mas larga en la cadena");
            Console.WriteLine("Ingrese la cadena:");
            string str = Console.ReadLine();
            string[] palabra = str.Split();

            string PalabraMasLarga = "";
            //Para encontrar la palabra mas larga
            foreach(string letra in palabra)
            {
                if(letra.Length > PalabraMasLarga.Length)
                {
                    PalabraMasLarga = letra;
                }
            }
            Console.WriteLine($"La palabra mas larga es: {PalabraMasLarga}");
            Console.ReadKey();
        }
    }
}
       
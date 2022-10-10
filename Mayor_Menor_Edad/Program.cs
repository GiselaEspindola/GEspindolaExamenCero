using System;

namespace Mayor_Menor_Edad
{
    class program
    {
        static void Main(string[]args)
        {
            int i;
            int mayores;
            int menores;
           
            mayores = 0;
            menores = 0;

            for (i = 1; i <= 15; i++)
            {
                int edad;

                Console.WriteLine("Introduzca las edades de las personas");
                edad = Convert.ToInt32(Console.ReadLine());
                if(edad >= 18)
                {
                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;
                }
            }
            Console.WriteLine("Personas mayores de edad:" + mayores);
            Console.WriteLine("Personas menores de edad:" + menores);
        }
    }
}

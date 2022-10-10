using System;

namespace Empleados
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" Elija la opcion que desee:     ");
            Console.WriteLine(" Si deseas saber el suedo de Jacobo Agami elige el 1: \nSi deseas saber el suedo de Alvaro Gozalez elige el 2: \nSi deseas saber el suedo de Mario Ramon elige el 3:");
            int val = int.Parse(Console.ReadLine());

            switch(val)
            {
                case 1:
                    
                    Empleado.CalculaSueldo("Jacobo", "Agami", 500);
                    break;
                case 2:
                    
                    Empleado.CalculaSueldo("Alvaro", "Gonzalez", 400);
                    break;
                case 3:
                    
                    Empleado.CalculaSueldo("Mario", "Ramon", 300);
                    break;


            }

            //Empleado.CalculaSueldo("Jacobo", "Agami", 500);
            //Empleado.CalculaSueldo("Alvaro", "Gonzalez", 400);
            //Empleado.CalculaSueldo("Mario", "Ramon", 300);

        }
    }
}
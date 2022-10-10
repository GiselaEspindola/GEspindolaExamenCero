using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public class Empleado
    {
       

       public static void CalculaSueldo(string Nombre, string Apellido,int SalarioDIario)
        {
            //Calcular el salario Mensual
            int monto = SalarioDIario * 30;
            Console.WriteLine("\nNombre del Empleado: " + Nombre + "\n Apellido:" + Apellido + "\nSu salario al dia es de:" + SalarioDIario + "\nSu salario mensual es de:" + monto);
            Console.ReadLine();
        }
    }
    
}
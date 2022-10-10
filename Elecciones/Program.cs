using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Elecciones
{
    class program
    {
        static void Main(string[] args)
        {
            int vo1 = 0, vo2 = 0, vo3 = 0, max, voto;
            double voo1, voo2, voo3, total;
            string Ganador;


            Console.WriteLine(" Si deseas votar por el CANDIDATO A elige el 1:");
            Console.WriteLine(" Si deseas votar por el CANDIDATO B elige el 2:");
            Console.WriteLine(" Si deseas votar por el CANDIDATO C elige el 3:");
            Console.WriteLine(" Presiona 4 para terminar de votar");

            do
            {
                Console.Write("Ingrese su voto:   ");
                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                {
                    vo1 = vo1 + 1;
                }
                else if (voto == 2)
                {
                    vo2 = vo2 + 1;
                }
                else if (voto == 3)
                {
                    vo3 = vo3 + 1;
                }

            }
            while (voto != 4);

            total = vo1 + vo2 + vo3;
            voo1 = (vo1 / total) * 100;
            voo2 = (vo2 / total) * 100;
            voo3 = (vo3 / total) * 100;


            Console.WriteLine("El candidato A tiene: {0}", voo1);
            Console.WriteLine("El candidato B tiene: {0}", voo2);
            Console.WriteLine("El candidato C tiene: {0}", voo3);

            if (vo1 == vo2 && vo1== vo3 && vo2 == vo3)
            {
                Console.WriteLine("Los tres candidatos tienen el mismo numero de votos ");
            }
            else
            {
                if (vo1 == vo2 && vo1 > vo3)
                {
                    Console.WriteLine("Los candidatos A Y B tienen el mismo numero de votos ");
                }
                else
                {
                    if (vo1 == vo3 && vo1 > vo2)
                    {
                        Console.WriteLine("Los candidatos A Y C tienen el mismo numero de votos ");
                    }
                    else
                    {
                        if (vo2 == vo3 && vo2 > vo3)
                        {
                            Console.WriteLine("Los candidatos B Y C tienen el mismo numero de votos ");
                        }
                        else
                        {
                            if (vo1 > vo2)
                            {
                                if (vo1> vo3)
                                {
                                    Console.WriteLine("El candidato A es el ganador ");
                                }
                                else
                                {
                                    Console.WriteLine("El candidato C es el ganador ");
                                }
                            }
                            else
                            {
                                if (vo2 > vo3)
                                {
                                    Console.WriteLine("El candidato B es el ganador ");
                                }
                                else
                                {
                                    Console.WriteLine("El candidato C es el ganador ");
                                }
                            }
                        }
                    }
                }
            }
        }
        //max = vo1;
        //Ganador = "Candidato A";
        //if (vo2 > max)
        //{
        //    Ganador = "Candidato B";
        //}
        //if (vo3 > max)
        //{
        //    Ganador = "Candidato C";
        //}
        //Console.WriteLine("Felicidades el ganadaro es: {0}", Ganador);
    }
    
}
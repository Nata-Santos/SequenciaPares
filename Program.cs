﻿using System;

namespace Sequenciapares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int inicio = 0;
            bool numeroCorreto;


            Console.WriteLine("----Sequência Pares----");
            Console.Write("Números pares entre 0 e ? ");
            numeroCorreto = Int32.TryParse(Console.ReadLine(), out numero);



            if (numeroCorreto)
            {
                Console.WriteLine($"{inicio}");

                while (inicio <= numero - 2)
                {
                    inicio = inicio + 2;
                    Console.WriteLine($"{inicio}");
                }
            }
            else if (!numeroCorreto)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite um número válido");
                Console.ResetColor();
            }

        }
    }
}
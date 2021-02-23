using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n============= Calculadora ==============");

            Console.Write("Insiara  um numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Escolha um operador: |/| Divisão, |*| Multiplicação, |+| Soma, |-| Subtração:  ");
            string operador = Console.ReadLine();

            Console.Write("Insiara  um numero: ");
            int numero2 = int.Parse(Console.ReadLine());


            switch (operador)
            {
                case "+":
                    int resultado = (numero1 + numero2);
                    Console.WriteLine($"{ numero1 } {'+'} { numero2 } = {resultado}");
                    break;

                case "/":
                    int resultado2 = (numero1 / numero2);
                    Console.WriteLine($"{ numero1 } {'/'} { numero2 } = {resultado2}");
                    break;

                case "-":
                    int resultado3 = (numero1 - numero2);
                    Console.WriteLine($"{ numero1 } {'-'} { numero2 } = {resultado3}");
                    break;

                case "*":
                    int resultado4 = (numero1 * numero2);
                    Console.WriteLine($"{ numero1 } {'*'} { numero2 } = {resultado4}");
                    break;

                default:
                    Console.WriteLine("Caracter nao reconhecido");
                    break;
            }

        }

    }
}


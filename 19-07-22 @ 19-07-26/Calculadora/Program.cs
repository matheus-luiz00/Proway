﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraSimples.Calculadoras;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculadoraSimplesMesmo();

            float value1, value2;


            /*
            Console.WriteLine("2+2");
            Console.WriteLine(calc.Somar(2, 2));
            Console.WriteLine("\n2-2");
            Console.WriteLine(calc.Diminuir(2,2));
            Console.WriteLine("\n2*2");
            Console.WriteLine(calc.Multiplicar(2, 2));
            Console.WriteLine("\n2/2");
            Console.WriteLine(calc.Dividir(2, 2));
            */

            Console.WriteLine("Digite a operação no seguinte formato: [10*3] [2,5+2,5]");
            string testt = Console.ReadLine();

            
            
            if(testt.Contains("+"))
            {
                testt = testt.Replace(" ", "");
                testt = testt.Replace(",", ".");
                testt = testt.Replace("+", ",");
                string[] array = testt.Split(',');
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i].Replace(".", ",");
                }
                float.TryParse(array[0], out value1);
                float.TryParse(array[1], out value2);
                Console.WriteLine(calc.Somar(value1, value2));

            }

            if (testt.Contains("-"))
            {
                testt = testt.Replace(" ", "");
                testt = testt.Replace(",", ".");
                testt = testt.Replace("-", ",");
                string[] array = testt.Split(',');
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i].Replace(".", ",");
                }
                float.TryParse(array[0], out value1);
                float.TryParse(array[1], out value2);
                Console.WriteLine(calc.Diminuir(value1, value2));

            }

            if (testt.Contains("*"))
            {
                testt = testt.Replace(" ", "");
                testt = testt.Replace(",", ".");
                testt = testt.Replace("*", ",");
                string[] array = testt.Split(',');
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i].Replace(".", ",");
                }
                float.TryParse(array[0], out value1);
                float.TryParse(array[1], out value2);
                Console.WriteLine(calc.Multiplicar(value1, value2));

            }

            if (testt.Contains("/"))
            {
                testt = testt.Replace(" ", "");
                testt = testt.Replace(",", ".");
                testt = testt.Replace("/", ",");
                string[] array = testt.Split(',');
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i].Replace(".", ",");
                }
                float.TryParse(array[0], out value1);
                float.TryParse(array[1], out value2);
                Console.WriteLine(calc.Dividir(value1, value2));

            }

















            /*
            Console.WriteLine("Soma:");
            Console.WriteLine("Digite um valor:");
            float.TryParse(Console.ReadLine(), out value1);
            Console.WriteLine("Digite um segundo valor:");
            float.TryParse(Console.ReadLine(), out value2);
            Console.WriteLine("Resultado:");
            Console.WriteLine(calc.Somar(value1, value2));
            Console.WriteLine();

            Console.WriteLine("Subtração:");
            Console.WriteLine("Digite um valor:");
            float.TryParse(Console.ReadLine(), out value1);
            Console.WriteLine("Digite um segundo valor:");
            float.TryParse(Console.ReadLine(), out value2);
            Console.WriteLine(calc.Diminuir(value1, value2));
            Console.WriteLine();

            Console.WriteLine("Multiplicação:");
            Console.WriteLine("Digite um valor:");
            float.TryParse(Console.ReadLine(), out value1);
            Console.WriteLine("Digite um segundo valor:");
            float.TryParse(Console.ReadLine(), out value2);
            Console.WriteLine(calc.Multiplicar(value1, value2));
            Console.WriteLine();

            Console.WriteLine("Divisão:");
            Console.WriteLine("Digite um valor:");
            float.TryParse(Console.ReadLine(), out value1);
            Console.WriteLine("Digite um segundo valor:");
            float.TryParse(Console.ReadLine(), out value2);
            Console.WriteLine(calc.Dividir(value1, value2));
            */
            Console.ReadKey();
        }
    }
}

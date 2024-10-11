using System;
using System.Threading.Tasks;
using Application;

namespace Calculator
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await Menu();
        }

        async static Task Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: await Soma(); break;
                case 2: await Subtracao(); break;
                case 3: await Divisao(); break;
                case 4: await Multiplicacao(); break;
                case 5: Environment.Exit(0); break;
                default: await Menu(); break;
            }
        }

        async static Task Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = await Operacoes.Somar(v1, v2);
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            await Menu();
        }

        async static Task Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = await Operacoes.Subtrair(v1, v2);
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            await Menu();
        }

        async static Task Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = await Operacoes.Dividir(v1, v2);
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            await Menu();
        }

        async static Task Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = await Operacoes.Multiplicar(v1, v2);
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            await Menu();
        }
    }
}

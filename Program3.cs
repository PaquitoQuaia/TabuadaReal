using System;

namespace Tabuada
{
    class TabuadaExibir
    {
        static void ExibirTabuada(int numero, string operacao)
        {
            int contador = 1;
            while (contador <= 10)
            {
                switch (operacao)
                {
                    case "+":
                        Console.WriteLine($"{numero} + {contador} = {numero + contador}");
                        break;
                    case "-":
                        Console.WriteLine($"{numero} - {contador} = {numero - contador}");
                        break;
                    case "*":
                        Console.WriteLine($"{numero} * {contador} = {numero * contador}");
                        break;
                    case "/":
                        Console.WriteLine($"{numero} / {contador} = {numero / (double)contador}");
                        break;
                    default:
                        Console.WriteLine("Operação inválida.");
                        return;
                }
                contador++;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite a operação (+, -, *, /): ");
            string operacao = Console.ReadLine();

            ExibirTabuada(numero, operacao);
        }
    }
}
using System;

namespace Tabuada
{
    class TabuadaExibir
    {
        static void ExibirTabuada(int numero)
        {
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador++;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um número para exibir a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            ExibirTabuada(numero);
        }
    }
}
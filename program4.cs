using System;

class TabuadaExibir
{
    static void ExibirTabuadaAteX(int numero, int limite, string operacao)
    {
        int contador = 1;
        while (contador <= limite)
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

        Console.Write("Digite o limite: ");
        int limite = int.Parse(Console.ReadLine());

        Console.Write("Digite a operação (+, -, *, /): ");
        string operacao = Console.ReadLine();

        ExibirTabuadaAteX(numero, limite, operacao);
    }
}
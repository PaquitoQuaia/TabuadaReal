  using System;

class TabuadaExibir
{
    static void ExibirTabuadaAteX(int numero, int limite)
    {
        int contador = 1;
        while (contador <= limite)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
            contador++;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Digite um número para exibir a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Digite o limite da tabuada: ");
        int limite = int.Parse(Console.ReadLine());

        ExibirTabuadaAteX(numero, limite);
    }
}

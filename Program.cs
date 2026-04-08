using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite ou pense algo sobre este programa:");
        string entrada = Console.ReadLine() ?? "";

        // Mantém apenas os 10 primeiros caracteres
        string reduzido = entrada.Length > 10 ? entrada.Substring(0, 10) : entrada;

        Console.WriteLine();
        Console.WriteLine("Usuário, o que você pensa sobre mim? Você é muito sem graça!");
        Console.WriteLine();
        Console.WriteLine("- E sabe o que eu penso de você?");
        Console.WriteLine($"{reduzido}... NÃO, PERA.");
        Console.WriteLine("Tô nervoso");
    }
}



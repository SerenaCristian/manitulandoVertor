using System;

class Program
{
    static void Main(string[] args)
    {
        string sep = new string('.', 50);
        string[] arrnomes = new string[10];

   
        AdicionaNomes(arrnomes);


        Console.WriteLine("Nomes cadastrados:");
        for (int i = 0; i < arrnomes.Length; i++)
        {
            Console.WriteLine($"Posição {i}: {arrnomes[i]}");
        }
    }

    static void AdicionaNomes(string[] arrnomes)
    {
        for (int i = 0; i < arrnomes.Length; i++)
        {
            Console.WriteLine($"Digite o nome :");
            arrnomes[i] = Console.ReadLine();
        }
    }
}



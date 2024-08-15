using System;

class Program
{
    static int tamanhoVetor = 10;
    static string[] nomes = new string[tamanhoVetor];

    static void Main(string[] args)
    {
        NomePorIndice("Ana", 0);
        NomePorIndice("Carlos", 2);
        NomePorIndice("Bruno", 1);
        NomePorIndice("Daniela", 3);
        NomePorIndice("Eduardo", 4);
        NomePorIndice("Fernanda", 5);
        NomePorIndice("Gabriel", 6);
        NomePorIndice("Helena", 7);
        NomePorIndice("Isabela", 8);
        NomePorIndice("João", 9);

        Console.WriteLine("Nomes no vetor antes da ordenação:");
        ExibirNomes();

        OrdenarNomes();

        Console.WriteLine("\nNomes no vetor após a ordenação:");
        ExibirNomes();

        
        RemoverNomePorIndice(3); 

        Console.WriteLine("\nNomes no vetor após remover o nome no índice 3:");
        ExibirNomes();

        Console.WriteLine("\nPressione qualquer tecla para fechar o programa...");
        Console.ReadKey();
    }

    static void NomePorIndice(string nome, int indice)
    {
        if (indice >= 0 && indice < tamanhoVetor)
        {
            if (nomes[indice] == null)
            {
                nomes[indice] = nome;
                Console.WriteLine($"Nome '{nome}' adicionado no índice {indice}.");
            }
            else
            {
                Console.WriteLine($"O índice {indice} já está ocupado pelo nome '{nomes[indice]}'.");
            }
        }
        else
        {
            Console.WriteLine($"Índice {indice} inválido. Deve estar entre 0 e {tamanhoVetor - 1}.");
        }
    }

    static void ExibirNomes()
    {
        foreach (var nome in nomes)
        {
            if (nome != null)
                Console.WriteLine(nome);
        }
    }

    static void OrdenarNomes()
    {
        for (int i = 0; i < tamanhoVetor - 1; i++)
        {
            for (int j = 0; j < tamanhoVetor - 1 - i; j++)
            {
                if (nomes[j] != null && nomes[j + 1] != null && string.Compare(nomes[j], nomes[j + 1]) > 0)
                {
                    string temp = nomes[j];
                    nomes[j] = nomes[j + 1];
                    nomes[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Nomes ordenados com sucesso.");
    }

    static void RemoverNomePorIndice(int indice)
    {
        if (indice >= 0 && indice < tamanhoVetor)
        {
            if (nomes[indice] != null)
            {
                Console.WriteLine($"Nome '{nomes[indice]}' removido do índice {indice}.");
                nomes[indice] = null;
            }
            else
            {
                Console.WriteLine($"O índice {indice} já está vazio.");
            }
        }
        else
        {
            Console.WriteLine($"Índice {indice} inválido. Deve estar entre 0 e {tamanhoVetor - 1}.");
        }
    }
}

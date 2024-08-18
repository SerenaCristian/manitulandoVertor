using System;
using System.Linq;

class Program
{
    static int tamanhoVetor = 10;
    static string[] nomes = new string[tamanhoVetor];

    static void Main(string[] args)
    {

        
        AdicionarNome(nomes, "Lucas");
        AdicionarNome(nomes, "Joaquim");
        AdicionarNome(nomes, "Rafael");
        AdicionarNome(nomes, "Maria");
        AdicionarNome(nomes, "Bruno");

        NomePorIndice("Ana", 0);
        NomePorIndice("Carlos", 2);
        NomePorIndice("Bruno", 1);
        NomePorIndice("Daniela", 3);

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

    public static void AdicionarNome(string[] listaNomes, string nome)
    {
        for (int i = 0; i < listaNomes.Length; i++)
        {
            if (string.IsNullOrEmpty(listaNomes[i]))
            {
                listaNomes[i] = nome;
                Console.WriteLine($"'{nome}' foi adicionado!");
                return;
            }
        }
        Console.WriteLine("Lista cheia. Não é possível adicionar mais nomes.");
    }

    public static void NomePorIndice(string nome, int indice)
    {
        if (indice < 0 || indice >= nomes.Length)
        {
            Console.WriteLine($"Índice inválido. Escolha um índice entre 0 e {nomes.Length - 1}");
            return;
        }

        bool vetorCheio = true;
        for (int i = 0; i < nomes.Length; i++)
        {
            if (string.IsNullOrEmpty(nomes[i]))
            {
                vetorCheio = false;
                break;
            }
        }

        if (vetorCheio)
        {
            Console.WriteLine("Lista cheia. Não é possível adicionar mais nomes.");
            return;
        }

        for (int i = nomes.Length - 1; i > indice; i--)
        {
            nomes[i] = nomes[i - 1];
        }

        nomes[indice] = nome;
        Console.WriteLine($"Nome '{nome}' adicionado com sucesso no índice {indice}!");
    }

    static void ExibirNomes()
    {
        ImprimeNomes(nomes);
    }

    public static void ImprimeNomes(string[] nomes)
    {
        bool vetorNull = false;
        for (int i = 0; i < nomes.Length; i++)
        {
            if (string.IsNullOrEmpty(nomes[i]))
            {
                vetorNull = true;
                break;
            }
        }

        if (nomes.All(n => string.IsNullOrWhiteSpace(n)))
        {
            Console.WriteLine("Lista vazia");
        }
        else
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
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


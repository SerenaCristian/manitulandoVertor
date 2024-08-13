using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criação da lista de nomes com capacidade inicial para 10 elementos
        List<string> nomes = new List<string>();

        // Adiciona 10 nomes iniciais
        AdicionarNome(nomes, "Adriano");
        AdicionarNome(nomes, "Arthur");
        AdicionarNome(nomes, "Caroline");
        AdicionarNome(nomes, "Charleu");
        AdicionarNome(nomes, "Cristian");
        AdicionarNome(nomes, "Luciano");
        AdicionarNome(nomes, "Thiago");
        AdicionarNome(nomes, "Niki Lauda");
        AdicionarNome(nomes, "Chicungunha");
        AdicionarNome(nomes, "Zé do Caixao");

        // Tentativa de adicionar mais um nome (não será adicionado pois a lista já está cheia)
        AdicionarNome(nomes, "zika vairus");

        // Tentativa de adicionar um nome em um índice específico
        AdicionarNomeEmIndice(nomes, 5, "Febre tifoide");

        // Ordena os nomes em ordem alfabética
        OrdenarNomes(nomes);

        // Imprime todos os nomes
        ImprimirNomes(nomes);

        // Mantém o console aberto até que o usuário pressione Enter
        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    }

    static void AdicionarNome(List<string> nomes, string nome)
    {
        if (nomes.Count < 10)
        {
            nomes.Add(nome);
            Console.WriteLine($"Nome '{nome}' adicionado com sucesso.");
        }
        else
        {
            Console.WriteLine("A lista já está cheia. Não é possível adicionar mais nomes.");
        }
    }

    static void AdicionarNomeEmIndice(List<string> nomes, int indice, string nome)
    {
        if (indice >= 0 && indice < 10)
        {
            if (indice < nomes.Count)
            {
                Console.WriteLine($"O índice {indice} já possui o nome '{nomes[indice]}'.");
            }
            else
            {
                nomes.Insert(indice, nome);
                Console.WriteLine($"Nome '{nome}' adicionado na posição {indice}.");
            }
        }
        else
        {
            Console.WriteLine("Índice inválido. Insira um índice entre 0 e 9.");
        }
    }

    static void OrdenarNomes(List<string> nomes)
    {
        nomes.Sort();
    }

    static void ImprimirNomes(List<string> nomes)
    {
        Console.WriteLine("Lista de Nomes:");
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}

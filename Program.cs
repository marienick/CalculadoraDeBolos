using ConsoleApp265;
using System;
using System.ComponentModel;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        QuantidadeDoProdutoUtilizado quantidadeDoProdutoUtilizado = new QuantidadeDoProdutoUtilizado();
        PrecoDosProdutos precoDosIngredientes = new PrecoDosProdutos();

        Console.WriteLine("Qual vai ser o nome deste bolo?");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Qual a descrição  do bolo?");
        string descricao = Console.ReadLine()!;
        Console.WriteLine("Esse bolo é para quantas pessoas?");
        int qtdDePessoas = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Quanto custou o kilo da farinha?");
        double PrecoDaFarinha = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Quantas gramas foram utilizadas da farinha?");
        double QuantidadeDeFarinha = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Quanto custou o caixa de ovos?");
        double PrecoDosOvos = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Quantos ovos foram utilizados?");
        int QuantidadeDeOvos = int.Parse(Console.ReadLine()!);


        Console.WriteLine("Quanto custou o litro do leite?");
        double PrecoDoLeite = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Quantos mililitros foram utilizados do leite?");
        double QuantidadeDeLeite = double.Parse(Console.ReadLine()!);


        Console.WriteLine("Quanto custou o kilo do açúcar?");
        double PrecoDoAçucar = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Quantas gramas foram utilizadas do açúcar?");
        double QuantidadeDeAçucar = double.Parse(Console.ReadLine()!);


        Console.WriteLine("Quanto custou o pote do fermento?");
        double PrecoDoFermento = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Quantas gramas foram utilizadas do fermento?");
        double QuantidadeDeFermento = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Quanto custou o kilo do sal?");
        double PrecoDoSal = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Quantas gramas foram utilizadas do sal?");
        double QuantidadeDeSal = double.Parse(Console.ReadLine()!);

        double Preco;
        double Quantidade;
        Console.WriteLine("Você utilizou o óleo ou manteiga?\n1-Óleo\n2-Manteiga");
        int opcao = int.Parse(Console.ReadLine()!);
        if (opcao == 1)
        {
            Console.WriteLine("Quanto custou o litro do óleo?");
            Preco = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Quantas miligramas foram utilizadas do óleo?");
            Quantidade = double.Parse(Console.ReadLine()!);
            quantidadeDoProdutoUtilizado = new QuantidadeDoProdutoUtilizado(QuantidadeDeFarinha, QuantidadeDeOvos, QuantidadeDeLeite, QuantidadeDeAçucar, QuantidadeDeFermento, QuantidadeDeSal, 0, Quantidade);
            precoDosIngredientes = new PrecoDosProdutos(PrecoDaFarinha, PrecoDosOvos, PrecoDoLeite, PrecoDoAçucar, PrecoDoFermento, PrecoDoSal, 0, Preco);
        }
        else if (opcao == 2)
        {
            Console.WriteLine("Quanto custou o pote de manteiga?");
            Preco = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Quantas gramas foram utilizadas da manteiga?");
            Quantidade = double.Parse(Console.ReadLine()!);
            quantidadeDoProdutoUtilizado = new QuantidadeDoProdutoUtilizado(QuantidadeDeFarinha, QuantidadeDeOvos, QuantidadeDeLeite, QuantidadeDeAçucar, QuantidadeDeFermento, QuantidadeDeSal, Quantidade, 0);
            precoDosIngredientes = new PrecoDosProdutos(PrecoDaFarinha, PrecoDosOvos, PrecoDoLeite, PrecoDoAçucar, PrecoDoFermento, PrecoDoSal, Preco, 0);

        }

        PrecoDosIngredientesUtilizados precoDosIngredientesUtilizados = new PrecoDosIngredientesUtilizados(precoDosIngredientes, quantidadeDoProdutoUtilizado);

        precoDosIngredientesUtilizados.ProdutosAdicionais();

        Console.WriteLine("Quanto vale seu trabalho com esse projeto?");
        double PrecoDoTrabalho = double.Parse(Console.ReadLine()!);
        double PrecoCompletoDoTrabalho = precoDosIngredientesUtilizados.PrecoTotal + PrecoDoTrabalho;

        string path = @"C:\Users\55319\Documents\DadosPedidos.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine($"Nome Do bolo: {nome}");
                writer.WriteLine($"Descrição: {descricao}");
                writer.WriteLine($"Este bolo é para {qtdDePessoas} pessoas");
                writer.WriteLine($"Valor total do bolo: {PrecoCompletoDoTrabalho}");
            }

            Console.WriteLine("Dados sobre o bolo registrados com sucesso no arquivo.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro ao escrever no arquivo: {ex.Message}");
        }
    }
}

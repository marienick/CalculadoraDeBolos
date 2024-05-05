using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp265
{
    internal class PrecoDosIngredientesUtilizados
    {
        public double FarinhaPreco { get; set; }
        public double OvosPreco { get; set; }
        public double LeitePreco { get; set; }
        public double AçucarPreco { get; set; }
        public double FermentoPreco { get; set; }
        public double SalPreco { get; set; }
        public double ManteigaPreco { get; set; }
        public double OleoPreco { get; set; } 
        Dictionary<ProdutoAdicional, double> ProdutoAdicionalsPreco { get; set; }
        public double PrecoTotal { get; set; }

        public PrecoDosIngredientesUtilizados(PrecoDosProdutos precoDosProdutos, QuantidadeDoProdutoUtilizado quantidadeDoProdutoUtilizado)
        {
            PrecoTotal += FarinhaPreco = CalcularPreco(1000,precoDosProdutos.Farinha, quantidadeDoProdutoUtilizado.Farinha);
            PrecoTotal += OvosPreco = CalcularPreco(30, precoDosProdutos.Ovos, quantidadeDoProdutoUtilizado.Ovos);
            PrecoTotal += LeitePreco = CalcularPreco(1000, precoDosProdutos.Leite, quantidadeDoProdutoUtilizado.Leite);
            PrecoTotal += AçucarPreco = CalcularPreco(1000, precoDosProdutos.Açucar, quantidadeDoProdutoUtilizado.Açucar);
            PrecoTotal += FermentoPreco = CalcularPreco(100, precoDosProdutos.Fermento, quantidadeDoProdutoUtilizado.Fermento);
            PrecoTotal += SalPreco = CalcularPreco(1000, precoDosProdutos.Sal, quantidadeDoProdutoUtilizado.Sal);
            PrecoTotal += ManteigaPreco = CalcularPreco(500, precoDosProdutos.Manteiga, quantidadeDoProdutoUtilizado.Manteiga);
            PrecoTotal += OleoPreco = CalcularPreco(1000, precoDosProdutos.Oleo, quantidadeDoProdutoUtilizado.Oleo);
        }

        public static double CalcularPreco(double quantidade, double preco, double quantidadeUtilizada)
        {
            return (quantidadeUtilizada / quantidade) * preco;
        }

        public void ProdutosAdicionais()
        {
            Console.WriteLine("Deseja adicionar mais ingredientes?\n1-Sim\n2-Não");
            int opcao = int.Parse(Console.ReadLine());
            if(opcao == 1)
            {
                Console.WriteLine("Quantos?");
                int qtd = int.Parse(Console.ReadLine());
                for(int i = 0; i < qtd; i++)
                {
                    Console.WriteLine("Qual o nome do produto?");
                    string NomeDoProduto = Console.ReadLine();
                    Console.WriteLine("Qual o preço do produto?");
                    double PrecoDoProduto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Qual a quantidade do produto comprado?");
                    double QuantidadeDoProduto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Qual a quantidade do produto utilizada?");
                    double QuantidadeDoProdutoUtilizada = Convert.ToDouble(Console.ReadLine());
                    ProdutoAdicional produtoAdicional = new ProdutoAdicional(NomeDoProduto, PrecoDoProduto, QuantidadeDoProduto, QuantidadeDoProdutoUtilizada);
                    double PrecoTotal = CalcularPreco(QuantidadeDoProduto, PrecoDoProduto, QuantidadeDoProdutoUtilizada);
                    this.PrecoTotal += PrecoTotal;
                    ProdutoAdicionalsPreco.Add(produtoAdicional, PrecoTotal);

                }
            }

        }
    }
}

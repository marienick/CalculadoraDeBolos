using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp265
{
    internal class ProdutoAdicional
    {
        public string NomeDoProduto { get; set; }
        public double PrecoDoProduto { get; set; }
        public double QuantidadeDoProduto { get; set; }
        public double QuantidadeDoProdutoUtilizada { get; set; }

        public ProdutoAdicional(string nomeDoProduto, double precoDoProduto, double quantidadeDoProduto, double quantidadeDoProdutoUtilizada)
        {
            NomeDoProduto = nomeDoProduto;
            PrecoDoProduto = precoDoProduto;
            QuantidadeDoProduto = quantidadeDoProduto;
            QuantidadeDoProdutoUtilizada = quantidadeDoProdutoUtilizada;
        }
    }
}

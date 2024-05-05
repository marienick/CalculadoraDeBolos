using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp265
{
    internal class QuantidadeDoProdutoUtilizado
    {
        public double Farinha { get; set; }
        public double Ovos { get; set; }
        public double Leite { get; set; }
        public double Açucar { get; set; }
        public double Fermento { get; set; }
        public double Sal { get; set; }
        public double Manteiga { get; set; }
        public double Oleo { get; set; }
        public QuantidadeDoProdutoUtilizado() { }

        public QuantidadeDoProdutoUtilizado(double farinha, double ovos, double leite, double açucar, double fermento, double sal, double manteiga = 0, double oleo = 0)
        {
            Farinha = farinha;
            Ovos = ovos;
            Leite = leite;
            Açucar = açucar;
            Fermento = fermento;
            Sal = sal;
            Manteiga = manteiga;
            Oleo = oleo;
        }
    }

}

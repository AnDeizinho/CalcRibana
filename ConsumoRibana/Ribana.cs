using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsumoRibana
{
    public class Ribana
    {
        const double compVies = 0.50;
        const double largVies = 0.05;
        double qtdnalarg = 0;
        public double Metros { get; private set; }
        public double Kilos { get; private set; }
        public double Largura { get; private set; }
        public double Gramatura { get; private set; }
        public int QtdCamisas { get; private set; }

        public Ribana(int camisas , double gram, double larg)
        {
            QtdCamisas = camisas;
            Largura = larg;
            qtdnalarg = larg / largVies;
            Metros = (camisas / qtdnalarg) * compVies;
            Kilos = (larg * gram) * Metros;
            Gramatura = gram;

        }
    }
}

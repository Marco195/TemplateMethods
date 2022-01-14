using System;
using TemplateMethods.Interfaces;

namespace TemplateMethods.Classes
{
    class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}

using System;
using TemplateMethods.Interfaces;

namespace TemplateMethods.Classes
{
    class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}

using StrategyTest.Classes;
using System;
using TemplateMethods.Templates;

namespace TemplateMethods.Classes
{
    public class IKCV : TemplateImpostoCondicional
    {
        public bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temitemMaiorQue100ReaisNo(orcamento);
        }

        public double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temitemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

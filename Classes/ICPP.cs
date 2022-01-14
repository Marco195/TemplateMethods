using TemplateMethods.Templates;
using TemplateMethods.Interfaces;

namespace TemplateMethods.Classes
{
    class ICPP : TemplateImpostoCondicional
    {
        public bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }


        public double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

    }
}

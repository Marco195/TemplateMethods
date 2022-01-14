using TemplateMethods.Classes;
using TemplateMethods.Interfaces;

/*O template auxilia na construção de novas implementações, onde aa regra principal ja foi definida no mesmo através de uma classe abstrata, 
 * se a regra de calculo mudar, basta alterar o template.*/

namespace TemplateMethods.Templates
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarTaxacaoMaxima(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}

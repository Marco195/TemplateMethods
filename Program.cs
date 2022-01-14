using System;
using TemplateMethods.Classes;
using TemplateMethods.Interfaces;

namespace TemplateMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto ICPP = new ICPP();
            Imposto IKCV = new IKCV();

            Orcamento orcamentoICPP = new Orcamento(600);
            Orcamento orcamentoIKCV = new Orcamento(200);


            Console.WriteLine(ICPP.Calcula(orcamentoICPP).ToString("N2"));
            Console.WriteLine(IKCV.Calcula(orcamentoIKCV).ToString("N2"));

            Console.ReadKey();
        }
    }
}

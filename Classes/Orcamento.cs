using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethods.Classes;

namespace TemplateMethods.Classes
{
    public class Orcamento
    {
        public double Valor { get; set; }
        internal List<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
        }
    }
}

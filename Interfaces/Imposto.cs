using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethods.Classes;

namespace TemplateMethods.Interfaces
{
    public interface Imposto
    {
        public double Calcula(Orcamento orcamento);
    }
}

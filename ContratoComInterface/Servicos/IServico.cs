using System;
using System.Collections.Generic;
using System.Text;

namespace ContratoComInterface.Servicos
{
    interface IServico
    {
        public double CalculaJuros(double valor, int Mes);
    }
}

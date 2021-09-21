using System;
using System.Collections.Generic;
using System.Text;

namespace ContratoComInterface.Servicos
{
    class ServicoPayPal : IServico
    {
        public double CalculaJuros(double valor, int Mes)
        {
            return valor + (valor * (0.01 * Mes));
        }
    }
}

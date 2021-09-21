using System;
using System.Collections.Generic;
using System.Text;

namespace ContratoComInterface.Entidades
{
    class Contrato
    {
        public int Numero { get; private set; }
        public DateTime Inicio { get; set; }
        public double ValorTotal { get; set; }

        public List<ParcelasFinais> ListaParcelas = new List<ParcelasFinais>();

        public Contrato(int numero, DateTime inicio, double valorTotal)
        {
            Numero = numero;
            Inicio = inicio;
            ValorTotal = valorTotal;
        }
    }
}

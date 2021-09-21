using System;
using System.Collections.Generic;
using System.Text;

namespace ContratoComInterface.Entidades
{
    class ParcelasFinais
    {
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public ParcelasFinais(double valor, DateTime data)
        {
            Valor = valor;
            Data = data;
        }

        public override string ToString()
        {
            return $"{Data.ToString("dd/MM/yyyy")} = {Valor}";
        }
    }
}

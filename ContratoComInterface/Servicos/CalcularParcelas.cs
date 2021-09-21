using System;
using ContratoComInterface.Entidades;

namespace ContratoComInterface.Servicos
{
    class CalcularParcelas
    {
        public IServico Calculo { get; set; }
        public int NumeroDeParcelas { get; set; }

        public CalcularParcelas(IServico calculo, int numeroDeParcelas)
        {
            Calculo = calculo;
            NumeroDeParcelas = numeroDeParcelas;
        }
        public void CalculaParcelas(Contrato Contrato)
        {
            double valorParcelas = Contrato.ValorTotal / NumeroDeParcelas;
            for (int i = 1; i <= NumeroDeParcelas; i++)
            {
                double juros = Calculo.CalculaJuros(valorParcelas, i);
                double valorFinal = juros + (juros * 0.02);

                DateTime DataParcela = Contrato.Inicio.AddMonths(i);

                Contrato.ListaParcelas.Add(new ParcelasFinais(valorFinal, DataParcela));
            }
        }
    }
}

using System;
using System.Globalization;
using ContratoComInterface.Entidades;
using ContratoComInterface.Servicos;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contrato contrato = new Contrato(contractNumber, contractDate, contractValue);


            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            CalcularParcelas ContaParcelas = new CalcularParcelas(new ServicoPayPal(), months);

            ContaParcelas.CalculaParcelas(contrato);

            foreach (ParcelasFinais x in contrato.ListaParcelas)
                Console.WriteLine(x);

        }
    }
}
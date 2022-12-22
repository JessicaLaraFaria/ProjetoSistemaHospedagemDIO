using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ProjetoSistemaHospedagem.Modelos;

namespace ProjetoSistemaHospedagem
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Suite> suites = new List<Suite>()
            {
                new Suite(tipoSuite: "Simples", capacidade: 3, valorDiaria: 55M),
                new Suite(tipoSuite: "Dupla", capacidade: 4, valorDiaria: 85M),
                new Suite(tipoSuite: "Master", capacidade: 3, valorDiaria: 125M),
            };

            List<Pessoa> hospedes = new List<Pessoa>();
            Pessoa pessoa = new Pessoa();
            Suite suite = new Suite();


            pessoa.CadastraPessoa(hospedes);
            Suite tipoSuite = suite.EscolherSuite(suites);

            Console.Write("\nQuantidade de diárias: ");
            int diasReservados = int.Parse(Console.ReadLine());

            Reserva reserva = new Reserva(diasReservados);
            //reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(tipoSuite, hospedes);

            Console.WriteLine($"\nHóspedes:  {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor para reserva de {diasReservados} dias: {reserva.CalcularValorDiaria(tipoSuite)}");
        }
    }
}

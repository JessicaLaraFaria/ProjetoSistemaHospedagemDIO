
using System;
using System.Collections.Generic;

namespace ProjetoSistemaHospedagem.Modelos
{
    
    public class Suite
    {
        public string TipoSuite { get ; set;}
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public Suite() { }

        public Suite EscolherSuite(List<Suite> suites)
        {
            Console.WriteLine("\nEscolha uma Suite: \n1 - Suíte Simples\n2 - Suíte Dupla\n3 - Suíte Master");
            string n= Console.ReadLine();

            if(n == "1")
            {
                return suites[0];
            }else if(n== "2")
            {
                return suites[1];
            }
            else
            {
                return suites[2];
            }
        }
    }
}

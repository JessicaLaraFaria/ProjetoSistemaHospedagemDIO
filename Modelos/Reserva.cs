using System;
using System.Collections.Generic;

namespace ProjetoSistemaHospedagem.Modelos
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(){}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(Suite tipoSuite, List<Pessoa> hospedes)
        {             
            if (tipoSuite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A suíte não comporta a quantidade de hóspedes.");
                return;
            }
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = 0;
            foreach(Pessoa pessoa in Hospedes)
            {
                quantidade ++;
            }
            return quantidade;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public decimal CalcularValorDiaria(Suite tipoSuite)
        {
            decimal valor = DiasReservados * tipoSuite.ValorDiaria;

            if (DiasReservados >= 10)
            {           
                decimal desconto = (valor * 10)/ 100;
                valor -= desconto;
            }
         return valor;
        }
    }
}

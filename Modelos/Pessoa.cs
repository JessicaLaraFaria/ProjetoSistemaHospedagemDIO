
using System.Collections.Generic;
using System;

namespace ProjetoSistemaHospedagem.Modelos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public Pessoa() { }

        public List<Pessoa> CadastraPessoa(List<Pessoa> hospedes)
        {
            Console.Write("Quantidade de pessoas a hospedar: ");
            int qtt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtt; i++)
            {
                Console.Write("\n" + i + "- Nome: ");
                string nome = Console.ReadLine();
                hospedes.Add(new Pessoa(nome));
            }
            return hospedes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExpectativaDeVida
{
    public class Pessoa
    {
        private readonly int _expectativaMasculino = 73;
        private readonly int _expectativaFeminino = 80;

        public Pessoa(string nome, string sexo, DateTime dataNascimento)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }

        public void ImprimeTempoVidaRestante()
        {
            if (Sexo.ToUpper() == "M")
            {
                var idade = DateTime.Now.Year - DataNascimento.Year;

                Console.WriteLine($"Sua expectativa de vida é de {_expectativaMasculino} e você deverá viver mais {_expectativaMasculino - idade}");
            }
            else if (Sexo.ToUpper() == "F")
            {
                var idade = DateTime.Now.Year - DataNascimento.Year;

                Console.WriteLine($"Sua expectativa de vida é de {_expectativaFeminino} e você deverá viver mais {_expectativaFeminino - idade}");
            }
            else
            {
                Console.WriteLine("Sexo informado errado, informe M ou F.");
            }
        }
    }
}
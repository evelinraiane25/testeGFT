using System;
using System.Collections.Generic;
using System.Text;

namespace AcoesAnimal
{
    public class Animal : AcoesAnimal
    {
        public Animal(string nome, Classe classe, Alimentacao alimentacao) : base(classe, alimentacao)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
    }
}
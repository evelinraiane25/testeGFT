using System;
using System.Collections.Generic;
using System.Text;

namespace AcoesAnimal
{
    public class AcoesAnimal : IAcoesAnimal
    {
        public AcoesAnimal(Classe classe, Alimentacao alimentacao)
        {
            Classe = classe;
            Alimentacao = alimentacao;
        }

        public Classe Classe { get; set; }
        public Alimentacao Alimentacao { get; set; }

        public void Alimentar()
        {
            switch (Alimentacao)
            {
                case Alimentacao.Herbivoro:
                    Console.WriteLine("Alimentar com vegetais.");
                    break;
                case Alimentacao.Onivoro:
                    Console.WriteLine("Alimentar com mix de Carne e Vegetais.");
                    break;
                case Alimentacao.Carnivoro:
                    Console.WriteLine("Alimentar com carne.");
                    break;
                default:
                    break;
            }
        }

        public void Locomover()
        {
            switch (Classe)
            {
                case Classe.Anfibios:
                    Console.WriteLine("Andar ou nadar.");
                    break;
                case Classe.Repteis:
                    Console.WriteLine("Andar ou nadar.");
                    break;
                case Classe.Aves:
                    Console.WriteLine("Voar.");
                    break;
                case Classe.Mamiferos:
                    Console.WriteLine("Andar.");
                    break;
                default:
                    break;
            }
        }
    }
}
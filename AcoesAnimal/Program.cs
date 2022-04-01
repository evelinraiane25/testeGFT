using System;

namespace AcoesAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalUm = new Animal("Abelha", Classe.Aves, Alimentacao.Herbivoro);
            Console.WriteLine(animalUm.Nome);
            animalUm.Locomover();
            animalUm.Alimentar();

            var animalDois = new Animal("Jacaré", Classe.Repteis, Alimentacao.Carnivoro);
            Console.WriteLine(animalDois.Nome);
            animalDois.Locomover();
            animalDois.Alimentar();

            var animalTres = new Animal("Porco", Classe.Mamiferos, Alimentacao.Onivoro);
            Console.WriteLine(animalTres.Nome);
            animalTres.Locomover();
            animalTres.Alimentar();
        }
    }
}

using System;

namespace ExpectativaDeVida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe seu sexo, M para Masculino e F para Feminino:");
            var sexo = Console.ReadLine();

            Console.WriteLine("Informe sua data de nascimento:");
            var dataNascimento = Convert.ToDateTime(Console.ReadLine());

            var pessoa = new Pessoa(nome, sexo, dataNascimento);
            pessoa.ImprimeTempoVidaRestante();
        }
    }
}
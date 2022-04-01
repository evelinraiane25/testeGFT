using System;

namespace VetorPosicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQuantidade de números a informar?");
            int tamanhoVetor = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[tamanhoVetor];
            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine("\nInforme os números do vetor: ");
                int numeroInformado = Convert.ToInt32(Console.ReadLine());
                array[i] = numeroInformado;
            }

            int numerosPares = 0;
            int numerosImpares = 0;
            int totalDeNumerosRepitidos = 0;
            for (int i = 0; i < tamanhoVetor; i++)
            {
                int numero = array[i];
                if (numero % 2 == 0)
                {
                    numerosPares = numerosPares + 1;
                }
                else
                {
                    numerosImpares = numerosImpares + 1;
                }

                int quantidadeRepeticao = 0;
                for (int j = i + 1; j < tamanhoVetor - 1; j++)
                {
                    int numeroComparar = array[j];
                    if (numero == numeroComparar)
                    {
                        quantidadeRepeticao = quantidadeRepeticao + 1;
                    }
                }

                if (quantidadeRepeticao > 0)
                {
                    totalDeNumerosRepitidos = totalDeNumerosRepitidos + 1;
                    Console.WriteLine("\nNúmero repetido: " + numero);
                }
            }

            Console.WriteLine("\nQuantidade de números pares: " + numerosPares);
            Console.WriteLine("\nQuantidade de números impares: " + numerosImpares);
            Console.WriteLine("\nQuantidade de números repetidos: " + totalDeNumerosRepitidos);
        }
    }
}

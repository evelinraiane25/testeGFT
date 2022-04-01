using System;

namespace CadastroEquipamento
{
    class Program
    {
        static void Main(string[] args)
        {
            InsereERetornaInformacoesCpu();

            InsereERetornaInformacoesDiscoRigido();

            InsereERetornaInformacoesMemoria();
        }

        public static void InsereERetornaInformacoesCpu()
        {
            Console.WriteLine($"Informe o clock do cpu:");
            var clock = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Informe o modelo do cpu:");
            var modelo = Console.ReadLine();

            Console.WriteLine($"Informe o ID do cpu:");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe o ID do cpu:");
            var descricao = Console.ReadLine();

            Console.WriteLine($"Informe o valor do cpu:");
            var valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Informe o fabricante do cpu:");
            var fabricante = Console.ReadLine();

            var cpu = new Cpu(clock, modelo, id, descricao, valor, fabricante);

            cpu.GetDetalhesHardware();
        }

        public static void InsereERetornaInformacoesDiscoRigido()
        {
            Console.WriteLine($"Informe a capacidade do disco rígido:");
            var capacidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe a capacidade do disco rígido:");
            var velocidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe o tipo do disco rígido:");
            var tipo = Console.ReadLine();

            Console.WriteLine($"Informe o ID do disco rígido:");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe a descrição do disco rígido:");
            var descricao = Console.ReadLine();

            Console.WriteLine($"Informe o valor do disco rígido:");
            var valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Informe o fabricante do disco rígido:");
            var fabricante = Console.ReadLine();

            var discoRigido = new DiscoRigido(capacidade, velocidade, tipo, id, descricao, valor, fabricante);
            discoRigido.GetDetalhesHardware();
        }

        public static void InsereERetornaInformacoesMemoria()
        {
            Console.WriteLine($"Informe a frquência da memória:");
            var frequencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe a capacidade da memória:");
            var capacidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe o tipo da memória:");
            var tipo = Console.ReadLine();

            Console.WriteLine($"Informe o ID da memória:");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Informe a descrição da memória:");
            var descricao = Console.ReadLine();

            Console.WriteLine($"Informe o valor da memória:");
            var valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Informe o fabricante da memória:");
            var fabricante = Console.ReadLine();

            var memoria = new Memoria(frequencia, capacidade, tipo, id, descricao, valor, fabricante);
            memoria.GetDetalhesHardware();
        }
    }

}

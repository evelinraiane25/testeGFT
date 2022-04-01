using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEquipamento
{

    public class DiscoRigido : Hardware
    {
        public DiscoRigido(int capacidade, int velocidade, string tipo, int id, string descricao, decimal valor, string fabricante) : base(id, descricao, valor, fabricante)
        {
            Capacidade = capacidade;
            Velocidade = velocidade;
            Tipo = tipo;
        }

        public int Capacidade { get; set; }
        public int Velocidade { get; set; }
        public string Tipo { get; set; }

        public void GetDetalhesHardware()
        {
            base.GetDetalhesHardware();
            Console.WriteLine($"Capacidade: {Capacidade} TB");
            Console.WriteLine($"Velocidade: {Velocidade} RPM");
            Console.WriteLine($"Tipo: {Tipo}");
        }
    }
}



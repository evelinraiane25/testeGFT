using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEquipamento
{
    
        public class Memoria : Hardware
        {
            public Memoria(int frequencia, int capacidade, string tipo, int id, string descricao, decimal valor, string fabricante) : base(id, descricao, valor, fabricante)
            {
                Frequencia = frequencia;
                Capacidade = capacidade;
                Tipo = tipo;
            }

            public int Frequencia { get; set; }
            public int Capacidade { get; set; }
            public string Tipo { get; set; }

            public void GetDetalhesHardware()
            {
                base.GetDetalhesHardware();
                Console.WriteLine($"Frequência: {Frequencia} MHZ");
                Console.WriteLine($"Capacidade: {Capacidade} GB");
                Console.WriteLine($"Tipo: {Tipo}");
            }
        }
    }
}


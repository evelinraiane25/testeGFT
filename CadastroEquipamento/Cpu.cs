using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEquipamento
{
    
        public class Cpu : Hardware
        {
            public Cpu(decimal clock, string modelo, int id, string descricao, decimal valor, string fabricante) : base(id, descricao, valor, fabricante)
            {
                Clock = clock;
                Modelo = modelo;
            }

            public decimal Clock { get; set; }
            public string Modelo { get; set; }

            public void GetDetalhesHardware()
            {
                base.GetDetalhesHardware();
                Console.WriteLine($"Clock: {Clock} GHZ");
                Console.WriteLine($"Modelo: {Modelo}");
            }
        }
    }
}

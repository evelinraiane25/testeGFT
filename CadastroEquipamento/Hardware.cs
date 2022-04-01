using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEquipamento
{
    
        public class Hardware
        {
            public Hardware(int id, string descricao, decimal valor, string fabricante)
            {
                Id = id;
                Descricao = descricao;
                Valor = valor;
                Fabricante = fabricante;
            }

            public int Id { get; set; }
            public string Descricao { get; set; }
            public decimal Valor { get; set; }
            public string Fabricante { get; set; }

            public void GetDetalhesHardware()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Descrição: {Descricao}");
                Console.WriteLine($"Valor: R$ {Valor:F2}");
                Console.WriteLine($"Fabricante: {Fabricante}");
            }
        }
    }
}


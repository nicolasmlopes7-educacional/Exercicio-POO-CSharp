using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int? Idade { get; set; }
        public string? Cidade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"{Nome} tem {Idade} anos e mora na cidade de {Cidade}");
        }
    }
}
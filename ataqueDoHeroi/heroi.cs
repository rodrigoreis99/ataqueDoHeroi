using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ataqueDoHeroi
{
    public class Heroi
    {
        public string Nome { get; }
        public int Idade { get; }
        public string Tipo { get; }

        public Heroi(string nome, int idade, string tipo)
        {
            Nome = nome;
            Idade = idade;
            Tipo = char.ToUpper(tipo[0]) + tipo.Substring(1).ToLower();
        }
        public void Atacar()
        {
            string ataque = Tipo.ToLower() switch
            {
                "mago" => "usou magia",
                "guerreiro" => "usou espada",
                "monge" => "usou artes marciais",
                "ninja" => "usou shuriken",
                _ => "usou um ataque desconhecido"
            };
            Console.WriteLine($"O {Tipo} atacou usando {ataque}");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Tipo: {Tipo}");
        }
    }
}

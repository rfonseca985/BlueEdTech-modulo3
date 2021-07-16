using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Codelabs_Parte1
{
    class Monstro
    {
        public string nome { get; set; }
        public int vida { get; set; }
        public int experiencia { get; set; }
        public int ataque { get; set; }
        public Monstro(string nome, int vida, int ataque)
        {
            this.nome = nome;
            this.vida = vida;
            this.ataque = ataque;
            this.experiencia = vida + ataque;
        }
    } 
}

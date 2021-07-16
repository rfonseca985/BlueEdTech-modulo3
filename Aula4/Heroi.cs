using System;

namespace Aula4_Codelabs_Parte1
{
    
	public class Heroi
    {
        public string nome { get; set; )
        public int experiencia { get; set; }
        public int nivel { get; set; }
        public int vida { get; set; }
        public int ataqueBase { get; set; }
        public int ataque { get; set; }

        public Heroi(string nome)
        {
            Random rand = new Random();
            this.nome = nome;
            this.experiencia = experiencia = 0;
            this.nivel = nivel = 1;
            this.vida = vida = 10;
            this.ataqueBase = rand.Next(1, 11);
            this.ataque = ataqueBase;

        }

        public void ganhaXP(int experiencia)
        {
            this.experiencia += experiencia;
            int novo_nivel = (xp / 10) + 1;
            if (novo_nivel > nivel)
            {
                Console.WriteLine("\n\nVocê aumentou de nível!");
                vida = novo_nivel * 10;
            }
            nivel = novo_nivel;
            ataque = ataqueBase + nivel;
        }
    }
}
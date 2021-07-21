using System;

namespace SalaDeAula.Models
{
    public class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }

        public int idade { get => Convert.ToInt32((DateTime.Now - dataNascimento).TotalDays / 365);}

        public Aluno(int id, string nome, DateTime dataNascimento)
        {
            this.id = id;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
        }
    }
}

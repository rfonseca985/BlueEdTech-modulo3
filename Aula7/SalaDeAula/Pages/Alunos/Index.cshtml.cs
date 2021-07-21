using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SalaDeAula.Models;

namespace SalaDeAula.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        public List<Aluno> alunos = new();
        public void OnGet()
        {
            this.alunos.Add(new Aluno(1, "Luis", new DateTime(1999,05,18)));
            this.alunos.Add(new Aluno(2, "Mariana", new DateTime(1988,10,23)));
            this.alunos.Add(new Aluno(3, "Guilherme", new DateTime(2000,08,04)));
            this.alunos.Add(new Aluno(4, "Luciana", new DateTime(1996,03,28)));
            this.alunos.Add(new Aluno(5, "Alberto", new DateTime(2004,02,16)));
        }
    }
}

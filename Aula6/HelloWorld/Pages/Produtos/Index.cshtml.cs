using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace HelloWorld.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        public List<Product> produtos = new List<Product>();

        public void OnGet()
        {
            carregarProdutos();
        }


        void carregarProdutos()
        {
            produtos.Add(new Product
            {
                Nome = "Calça",
                Preco = 150,
                Descricao = "Calça jeans"
            });
            produtos.Add(new Product
            {
                Nome = "Tênis",
                Preco = 200,
                Descricao = "Tênis de corrida"
            });
            produtos.Add(new Product
            {
                Nome = "Chapéu",
                Preco = 50,
                Descricao = "Chapéu de palha"
            });
        }
    }
}

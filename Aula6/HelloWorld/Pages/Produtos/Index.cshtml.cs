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
                Nome = "Cal�a",
                Preco = 150,
                Descricao = "Cal�a jeans"
            });
            produtos.Add(new Product
            {
                Nome = "T�nis",
                Preco = 200,
                Descricao = "T�nis de corrida"
            });
            produtos.Add(new Product
            {
                Nome = "Chap�u",
                Preco = 50,
                Descricao = "Chap�u de palha"
            });
        }
    }
}

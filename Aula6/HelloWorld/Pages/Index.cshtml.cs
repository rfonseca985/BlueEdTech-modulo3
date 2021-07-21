using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<string> produtos = new List<string>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Random rdn = new Random();

            if(rdn.Next() % 2 == 0)
                carregarProdutos();
        }

        void carregarProdutos()
        {
            produtos.Add("Calça sarja preta");
            produtos.Add("Blusa azul");
            produtos.Add("Jeans preto");
        }
    }
}

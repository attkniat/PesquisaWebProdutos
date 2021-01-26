
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaWebCrawler.Models
{
    public class Refeição
    {
        public string nomeProduto { get; set; }
        public string descricaoProduto { get; set; }
        public string imagemProduto { get; set; }
        public string linkProduto { get; set; }
    }
}

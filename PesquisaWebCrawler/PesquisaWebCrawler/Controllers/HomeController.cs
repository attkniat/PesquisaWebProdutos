using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PesquisaWebCrawler.Models;
using HtmlAgilityPack;

namespace PesquisaWebCrawler.Controllers
{
    public class HomeController : Controller
    {
        #region logger

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        #endregion

        #region INDEX

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string produtoPesquisado)
        {
            if (produtoPesquisado != null)
            {
                using (var httpCliente = new HttpClient())
                {
                    var url = "https://www.giraffas.com.br/?s=" + produtoPesquisado;
                    var htmlContent = await httpCliente.GetStringAsync(url);

                    var htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(htmlContent);

                    var divsProdutos = htmlDocument.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("c-highlight-box")).ToList();

                    var comidas = new List<Refeição>();

                    foreach (var produtos in divsProdutos)
                    {
                        var comida = new Refeição
                        {
                            nomeProduto = produtos?.Descendants("h2")?.FirstOrDefault().InnerText,
                            descricaoProduto = produtos?.Descendants("p")?.FirstOrDefault().InnerText,
                            imagemProduto = produtos?.Descendants("img")?.FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
                            linkProduto = produtos?.Descendants("a")?.FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value
                        };
                        comidas.Add(comida);
                        ViewBag.ProdutosLista = comidas;
                    }
                    return View(ViewBag.ProdutosLista);
                }
            }
            return View();
        }

        #endregion
    }
}
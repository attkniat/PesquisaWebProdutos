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

                    foreach (var produtos in divsProdutos)
                    {
                        var nomeProduto = produtos?.Descendants("h2")?.FirstOrDefault().InnerText;
                        var descricaoProduto = produtos?.Descendants("p")?.FirstOrDefault().InnerText;
                        var imagemProduto = produtos?.Descendants("img")?.FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value;
                        var linkProduto = produtos?.Descendants("a")?.FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value;
                    }
                }
            }
            return View();
        }
    }
}

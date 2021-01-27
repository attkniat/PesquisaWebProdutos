using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PesquisaWebCrawler.DataLayer;

namespace PesquisaWebCrawler.Controllers
{
    public class MinhasPesquisasController : Controller
    {
        #region DBCONTEXT

        private RefeicaoDBContext _Context;

        public MinhasPesquisasController(RefeicaoDBContext context)
        {
            _Context = context;
        }

        #endregion

        public IActionResult MinhasPesquisas()
        {
            try
            {
                var historicoLista = _Context.Refeicao.ToList();
                var qdtPesquisas = _Context.Refeicao.Count();

                ViewBag.historicoDePesquisa = historicoLista;
                ViewBag.qdtDePesquisa = qdtPesquisas;

                return View();
            }
            catch (Exception)
            {
                BadRequest($"Não foi possivel localizar históricos");
            }
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PesquisaWebCrawler.Models;

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

        public IActionResult Index()
        {
            return View();
        }
    }
}

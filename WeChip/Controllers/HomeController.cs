using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeChip.Enums;
using WeChip.Models;

namespace WeChip.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Método responsável pelo redirecionamento para a tela principal do Site
        /// </summary>
        /// <param name="viewBagMessage">Mensagem recebida da ClientController quando um novo cliente é cadastrado</param>
        /// <returns></returns>
        public IActionResult Index(string viewBagMessage = null, MessageTypeEnum messageType = MessageTypeEnum.none)
        {
            ViewBag.FlowMessage = viewBagMessage;
            ViewBag.MessageType = messageType;
            return View();
        }
       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

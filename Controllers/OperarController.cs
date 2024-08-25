using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC1.Models;

namespace PC1.Controllers
{
    public class OperarController : Controller
    {
        private readonly ILogger<OperarController> _logger;

        public OperarController(ILogger<OperarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ordenar(Bolsa bolsas)
        {
           
                bolsas = new Bolsa(
                    bolsas.Nombres, 
                    bolsas.Correo, 
                    bolsas.FechaOperacion, 
                    bolsas.Syp, 
                    bolsas.Dowjones, 
                    bolsas.Bonos, 
                    bolsas.MontoAbonar
                );

                List<Bolsa> listaBolsa = new List<Bolsa> { bolsas };
                ViewData["listaBolsa"] = listaBolsa;

                return View("Index", bolsas);
    
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
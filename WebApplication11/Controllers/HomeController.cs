using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Uslugi()
        {
            return View();
        }

        public IActionResult Okompanii()
        {
            return View();
        }

        public IActionResult Obekty()
        {
            return View();
        }

        public IActionResult Sertifikaty()
        {
            return View();
        }

        public IActionResult Partnery()
        {
            return View();
        }
        public IActionResult Partnery2()
        {
            return View();
        }
        public IActionResult Klientyonas()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Automation()
        {
            return View();
        }
        public IActionResult Videonabludenie()
        {
            return View();
        }
        public IActionResult Cabel()
        {
            return View();
        }
        public IActionResult Dostup()
        {
            return View();
        }
        public IActionResult Pojar()
        {
            return View();
        }
        public IActionResult Electro()
        {
            return View();
        }
        public IActionResult Techno()
        {
            return View();
        }
        public IActionResult Onas()
        {
            return View();
        }
        public IActionResult Videnie()
        {
            return View();
        }
        public IActionResult Celi()
        {
            return View();
        }
        public IActionResult Missiya()
        {
            return View();
        }
        public IActionResult Struktura()
        {
            return View();
        }
        public IActionResult Documenty()
        {
            return View();
        }
        public IActionResult Sotrudniki()
        {
            return View();
        }
        public IActionResult Kvartal()
        {
            return View();
        }
        public IActionResult Greenmall()
        {
            return View();
        }
        public IActionResult Gostinica()
        {
            return View();
        }
        public IActionResult Gospital()
        {
            return View();
        }
        public IActionResult Samruk()
        {
            return View();
        }
        public IActionResult Pavlodar()
        {
            return View();
        }
        public IActionResult Kokshetau()
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

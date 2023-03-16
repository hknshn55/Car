using Car.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Car.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public static List<Ekran> ekranlar = new List<Ekran>()
        {
            new Ekran() {  Adi="Lenovo", Boyut=15, Id=1},
            new Ekran() {  Adi="Asus", Boyut=16, Id=2},
            new Ekran() {  Adi="ThinkVision", Boyut=17, Id=3},
            new Ekran() {  Adi="MSI", Boyut=18, Id=4}
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Detaylar(int id)
        {
            Ekran ekran = ekranlar.FirstOrDefault(x => x.Id == id);
            return View(ekran);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Bilgiler()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EkranEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EkranEkle(Ekran ekran)
        {
            ekranlar.Add(ekran);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

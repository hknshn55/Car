using Car.Business.Abstract;
using Car.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.WebUI.Controllers
{
    public class HasarController : Controller
    {
        private IHasarService _hasarService { get; }
        public HasarController(IHasarService hasarService)
        {
            _hasarService = hasarService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var hasar = await _hasarService.GetAllHasar(id);
            return View(hasar);
        }
    }
}

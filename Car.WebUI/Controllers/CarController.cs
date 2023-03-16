using Car.Business.Abstract;
using Car.Entities.Concrete;
using Car.Entities.Dtos;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IArabaService _arabaService;
        public CarController(IArabaService arabaService)
        {            
            _arabaService = arabaService;
        }
        public async Task<IActionResult> CarList()
        {
            List<ArabaDetaylariDto> arabaDetaylariDtos =await _arabaService.GetArabaDetails(1);
            List<ArabaDto> model = await _arabaService.GetAllAraba();
            return View(model);
        }

        public async Task< IActionResult> CarDetails(int id)
        {
            ArabaDto araba =await _arabaService.GetAraba(id);
            return View(araba);
        }

        [HttpGet]
        public IActionResult CarAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CarAdd(ArabaDto arabaDto)
        {
            await _arabaService.ArabaAdd(arabaDto);
            return RedirectToAction("CarList");
        }


        public async Task<IActionResult> CarDelete( int id)
        {
            await _arabaService.ArabaDelete(id);
            return RedirectToAction("CarList");
        }

        public async Task<IActionResult> CarUpdate(int id)
        {
            ArabaDto arabaDto = await _arabaService.GetAraba(id);
            return View(arabaDto);   
        }


        [HttpPost]
        public async Task<IActionResult> CarUpdate(ArabaDto arabaDto)
        {
            await _arabaService.ArabaUpdate(arabaDto);
            return View("CarDetails",arabaDto);
        }

    }
}

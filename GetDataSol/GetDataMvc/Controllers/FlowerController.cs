using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GetDataMvc.BusinessObjects;
using GetDataMvc.Models;
using GetDataMvc.Services;



namespace GetDataMvc.Controllers
{



    [Route("flowers")]
    public class FlowerController : Controller
    {



        private FlowerService flowerService;



        public FlowerController()
        {
            this.flowerService = new FlowerService();
        }



        // GET /flowers/list
        [HttpGet("list")]
        public IActionResult ShowFlowerList()
        {
            List<Flower> flowers = this.flowerService.GetFlowers();

            FlowerListViewModel model = new FlowerListViewModel();
            model.Flowers = flowers;

            return View("FlowerList", model);
        }



        // GET /flowers/detail/3
        [HttpGet("detail/{id:int}")]
        public IActionResult ShowFlowerDetail([FromRoute] int id)
        {
            Flower flower = this.flowerService.GetFlower(id);

            FlowerDetailViewModel model = new FlowerDetailViewModel();
            model.Flower = flower;

            return View("FlowerDetail", model);
        }



    }



}

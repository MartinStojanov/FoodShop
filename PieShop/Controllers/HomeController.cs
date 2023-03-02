using Microsoft.AspNetCore.Mvc;
using FoodShop.Models;
using FoodShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeVIewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
            return View(homeViewModel);
        }
}
    }


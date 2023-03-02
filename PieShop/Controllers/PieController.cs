using Microsoft.AspNetCore.Mvc;
using FoodShop.Models;
using FoodShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            if (string.IsNullOrEmpty(category))
            {
                piesListViewModel.Pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                piesListViewModel.CurrentCategory = "All pies";
            }
            else
            {
                piesListViewModel.Pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category).ToList();
                piesListViewModel.CurrentCategory = category;
            }
            return View(piesListViewModel);
        }
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}

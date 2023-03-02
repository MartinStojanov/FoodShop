using FoodShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.ViewModels
{
    public class HomeVIewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}

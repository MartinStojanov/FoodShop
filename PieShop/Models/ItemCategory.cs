using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Models
{
    public class ItemCategory
    {
        public int ItemCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<FoodItem> FoodItems { get; set; }
    }
}

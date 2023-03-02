using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Models
{
    public class FoodItem
    {
        
        public int FoodItemId { get; set; }
        public string NameItem { get; set; }
        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsFoodOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }

        public ItemCategory Category { get; set; }

        public string Notes { get; set; }
    }
}

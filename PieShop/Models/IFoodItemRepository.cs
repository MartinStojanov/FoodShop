using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Models
{
    public interface IFoodItemRepository
    {
        IEnumerable<FoodItem> AllFood { get; }
        IEnumerable<FoodItem> FoodOfTheWeek { get; }
        FoodItem GetFoodItemById(int foodItemId);
    }
}

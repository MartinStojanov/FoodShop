using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Models
{
    public class FoodItemRepository : IFoodItemRepository
    {

        private readonly AppDbContext _appDbContext;

        public FoodItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<FoodItem> AllFood
        {
            get
            {
                return _appDbContext.FoodItems.Include(c => c.Category);
            }
        }
        public IEnumerable<FoodItem> FoodOfTheWeek
        {
            get
            {
                return _appDbContext.FoodItems.Include(c => c.Category).Where(p => p.IsFoodOfTheWeek);
            }
        }

        public FoodItem GetFoodItemById(int foodItemId)
        {

            return _appDbContext.FoodItems.FirstOrDefault(p => p.FoodItemId == foodItemId);
        }
    }
}


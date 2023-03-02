using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Models
{
    public class ItemCategoryRepository : IItemCategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ItemCategory> AllCategories => _appDbContext.ItemCategories;
    }
}

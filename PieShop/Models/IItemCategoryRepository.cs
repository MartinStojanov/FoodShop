using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Models
{
    public interface IItemCategoryRepository
    {
        IEnumerable<ItemCategory> AllCategories { get; }
    }
}

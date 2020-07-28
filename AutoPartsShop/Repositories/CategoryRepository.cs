using System.Collections.Generic;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;

namespace AutoPartsShop.Repositories
{
    public class CategoryRepository : ICategory
    {
        private readonly AutoPartsShopDbContext _autoPartsShopDbContext;

        public CategoryRepository(AutoPartsShopDbContext autoPartsShopDbContext)
        {
            _autoPartsShopDbContext = autoPartsShopDbContext;
        }

        public IEnumerable<Category> GetCategories => _autoPartsShopDbContext.Categories;
    }
}

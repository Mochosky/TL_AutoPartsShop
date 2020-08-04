using System.Collections.Generic;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;

namespace AutoPartsShop.Repositories
{
    /// <summary>
    /// Contains the repository for the Part Categories.
    /// </summary>
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AutoPartsShopDbContext _autoPartsShopDbContext;

        public CategoryRepository(AutoPartsShopDbContext autoPartsShopDbContext)
        {
            _autoPartsShopDbContext = autoPartsShopDbContext;
        }

        public IEnumerable<Category> GetCategories => _autoPartsShopDbContext.Categories;
    }
}

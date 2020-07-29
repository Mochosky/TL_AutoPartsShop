using System.Collections.Generic;

using AutoPartsShop.Models;

namespace AutoPartsShop.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }
    }
}

using System.Collections.Generic;

using AutoPartsShop.Models;

namespace AutoPartsShop.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories { get; }
    }
}

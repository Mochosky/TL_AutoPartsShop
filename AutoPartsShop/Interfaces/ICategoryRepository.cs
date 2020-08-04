using System.Collections.Generic;

using AutoPartsShop.Models;

namespace AutoPartsShop.Interfaces
{
    /// <summary>
    /// Interface that contains the contract for Repository and DI.
    /// </summary>
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }
    }
}

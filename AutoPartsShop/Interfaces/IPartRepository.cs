using System.Collections.Generic;

using AutoPartsShop.Models;

namespace AutoPartsShop.Interfaces
{
    /// <summary>
    /// Interface that contains the contract for Repository and DI.
    /// </summary>
    public interface IPartRepository
    {
        IEnumerable<Part> GetAllParts { get; }
        IEnumerable<Part> GetPartsOnSale { get; }
        Part GetPartById(int partId);
    }
}

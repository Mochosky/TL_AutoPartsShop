using System.Collections.Generic;

using AutoPartsShop.Models;

namespace AutoPartsShop.Interfaces
{
    public interface IPartRepository
    {
        IEnumerable<Part> GetAllParts { get; }
        IEnumerable<Part> GetPartsOnSale { get; }
        Part GetPartById(int partId);
    }
}

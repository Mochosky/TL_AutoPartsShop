using System.Collections.Generic;

using AutoPartsShop.Models;

namespace AutoPartsShop.Interfaces
{
    public interface IPart
    {
        IEnumerable<Part> GetAllParts { get; }
        IEnumerable<Part> GetPartsOnSale { get; }
        Part GetPartById(int partId);
    }
}

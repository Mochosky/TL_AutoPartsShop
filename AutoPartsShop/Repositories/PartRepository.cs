using System.Collections.Generic;
using System.Linq;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;

using Microsoft.EntityFrameworkCore;

namespace AutoPartsShop.Repositories
{
    public class PartRepository : IPartRepository
    {
        private readonly AutoPartsShopDbContext _autoPartsShopDbContext;

        public PartRepository(AutoPartsShopDbContext autoPartsShopDbContext)
        {
            _autoPartsShopDbContext = autoPartsShopDbContext;
        }

        public IEnumerable<Part> GetAllParts
        {
            get
            {
                return _autoPartsShopDbContext.Parts.Include(p => p.Category);
            }
        }

        public IEnumerable<Part> GetPartsOnSale
        {
            get
            {
                return _autoPartsShopDbContext.Parts.Include(p => p.Category).Where(x => x.IsOnSale);
            }
        }

        public Part GetPartById(int partId)
        {
            return _autoPartsShopDbContext.Parts.FirstOrDefault(p => p.PartId == partId);
        }
    }
}

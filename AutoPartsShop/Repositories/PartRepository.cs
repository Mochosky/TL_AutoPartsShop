using System.Collections.Generic;
using System.Linq;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;

using Microsoft.EntityFrameworkCore;

namespace AutoPartsShop.Repositories
{
    /// <summary>
    /// Contains the repository for the Parts.
    /// </summary>
    public class PartRepository : IPartRepository
    {
        private readonly AutoPartsShopDbContext _autoPartsShopDbContext;

        public PartRepository(AutoPartsShopDbContext autoPartsShopDbContext)
        {
            _autoPartsShopDbContext = autoPartsShopDbContext;
        }

        /// <summary>
        /// Get all the parts from the Database.
        /// </summary>
        public IEnumerable<Part> GetAllParts
        {
            get
            {
                return _autoPartsShopDbContext.Parts.Include(p => p.Category);
            }
        }

        /// <summary>
        /// Get all the parts on Sale status from the Database.
        /// </summary>
        public IEnumerable<Part> GetPartsOnSale
        {
            get
            {
                return _autoPartsShopDbContext.Parts.Include(p => p.Category).Where(x => x.IsOnSale);
            }
        }

        /// <summary>
        /// Get the specific part by ID.
        /// </summary>
        /// <param name="partId">The Part Identifier.</param>
        /// <returns></returns>
        public Part GetPartById(int partId)
        {
            return _autoPartsShopDbContext.Parts.FirstOrDefault(p => p.PartId == partId);
        }
    }
}

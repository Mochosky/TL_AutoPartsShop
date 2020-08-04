
using System.Collections.Generic;
using System.Linq;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;
using AutoPartsShop.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop.Controllers
{
    public class PartController : Controller
    {
        private readonly IPartRepository _partRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PartController(IPartRepository part, ICategoryRepository category)
        {
            _partRepository = part;
            _categoryRepository = category;
        }

        /// <summary>
        /// Generate the Part Detail view.
        /// </summary>
        /// <param name="id">Part ID.</param>
        /// <returns></returns>
        public IActionResult Details(int id)
        {
            var part = _partRepository.GetPartById(id);
            if (part == null)
                return NotFound();

            return View(part);
        }

        /// <summary>
        /// Filters the Parts by Category, returns all categories if empty.
        /// </summary>
        /// <param name="category">Category Name.</param>
        /// <returns></returns>
        public ViewResult List(string category)
        {
            IEnumerable<Part> parts;
            string currentcategory;

            if (string.IsNullOrEmpty(category))
            {
                parts = _partRepository.GetAllParts.OrderBy(p => p.PartId);
                currentcategory = "All Parts";
            }
            else
            {
                parts = _partRepository.GetAllParts
                    .Where(c => c.Category.Name == category);
                currentcategory = _categoryRepository.GetCategories
                    .FirstOrDefault(c => c.Name == category)?.Name;
            }

            // Creates the view model for the parts by category.
            return View(new PartListViewModel
            {
                CurrentCategory = currentcategory,
                Parts = parts
            });
        }

        /// <summary>
        /// Generate the Search Parts results.
        /// </summary>
        /// <param name="criteria">Search criteria.</param>
        /// <returns></returns>
        public ViewResult Search(string criteria)
        {
            var parts = _partRepository.GetAllParts
                .Where(p => p.Name.Contains(criteria, System.StringComparison.InvariantCultureIgnoreCase));

            // Creates the view model for the parts by search criteria.
            return View("List", new PartListViewModel
            {
                CurrentCategory = criteria,
                Parts = parts
            });
        }
    }
}


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

        public IActionResult Details(int id)
        {
            var part = _partRepository.GetPartById(id);
            if (part == null)
                return NotFound();

            return View(part);
        }

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

            return View(new PartListViewModel
            {
                CurrentCategory = currentcategory,
                Parts = parts
            });
        }

        public ViewResult Search(string criteria)
        {
            var parts = _partRepository.GetAllParts
                .Where(p => p.Name.Contains(criteria, System.StringComparison.InvariantCultureIgnoreCase));

            return View("List", new PartListViewModel
            {
                CurrentCategory = criteria,
                Parts = parts
            });
        }
    }
}

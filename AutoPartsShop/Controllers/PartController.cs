
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
        private readonly IPart _part;
        private readonly ICategory _category;

        public PartController(IPart part, ICategory category)
        {
            _part = part;
            _category = category;
        }

        public IActionResult Details(int id)
        {
            var part = _part.GetPartById(id);
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
                parts = _part.GetAllParts.OrderBy(p => p.PartId);
                currentcategory = "All Parts";
            }
            else
            {
                parts = _part.GetAllParts
                    .Where(c => c.Category.Name == category);
                currentcategory = _category.GetCategories
                    .FirstOrDefault(c => c.Name == category)?.Name;
            }

            return View(new PartListViewModel
            {
                CurrentCategory = currentcategory,
                Parts = parts
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

using AutoPartsShop.Interfaces;
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

        public IActionResult List()
        {
            // TODO: Remove the ViewBag and return the View Model instead of View.
            //ViewBag.ActualCategory = "On Sale";
            //return View(_part.GetAllParts);

            var partListViewModel = new PartListViewModel();
            partListViewModel.Parts = _part.GetAllParts;
            partListViewModel.CurrentCategory = "On Sale";

            return View(partListViewModel);
        }

        public IActionResult Details(int id)
        {
            var part = _part.GetPartById(id);
            if (part == null)
                return NotFound();

            return View(part);
        }
    }
}

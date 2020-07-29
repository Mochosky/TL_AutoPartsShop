using System.Linq;

using AutoPartsShop.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategory _category;

        public CategoryMenu(ICategory category)
        {
            _category = category;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _category.GetCategories.OrderBy(c => c.Name);

            return View(categories);
        }
    }
}


using Microsoft.AspNetCore.Mvc;

namespace AutoPartsShop.Controllers
{
    public class ContactController : Controller
    {
        /// <summary>
        /// Action result to generate the e-mail contact page.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}

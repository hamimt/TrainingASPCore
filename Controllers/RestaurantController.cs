using Microsoft.AspNetCore.Mvc;

namespace SampleASPCore.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            var model = new Models.Restaurant
            {
                Id = 1,
                Name = "Rasa Lapar"
            }
            return View(model);
        }
    }
}
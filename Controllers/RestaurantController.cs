using Microsoft.AspNetCore.Mvc;
using SampleASPCore.Services;

namespace SampleASPCore.Controllers
{
    public class RestaurantController : Controller
    {
        private IRestaurantData _resto; 
        public RestaurantController(IRestaurantData resto)
        {
            _resto = resto;
        }

        public IActionResult Details(int id){
            var model = _resto.GetByID(id);
            return View(model);
        }

        public IActionResult Index()
        {
            var models = _resto.GetAll();
            return View(models);
        }
    }
}
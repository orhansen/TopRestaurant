using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TopRestaurant.Models;

//Main controller to handel the getting and setting of information and views across the application
namespace TopRestaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult RestaurantInsert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RestaurantInsert(RestaurantResponse restaurant)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(restaurant);

                return View("Confirmation", restaurant);
            }
            else
            {
                return View();
            }
        }

        public IActionResult UserSubmissions()
        {
            return View(TempStorage.Restaurants);
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string? fDish = r.FavDish ?? "It's all tasty!";

                restaurantList.Add(string.Format("#{0}: {1}. Fav Dish: {2}. Address: {3}. Phone: {4}. Website: <a href={5}>{5}</a>",
                    r.RestaurantRank, r.RestaurantName, fDish, r.Address, r.PhoneNum, r.Website));
            }
            return View(restaurantList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

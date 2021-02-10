using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Temporary storage to hold the user inputted entries while the app is running
namespace TopRestaurant.Models
{
    public static class TempStorage
    {
        private static List<RestaurantResponse> restaurants = new List<RestaurantResponse>();

        public static IEnumerable<RestaurantResponse> Restaurants => restaurants;

        public static void AddRestaurant(RestaurantResponse restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}

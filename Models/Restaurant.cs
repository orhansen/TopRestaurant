using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This model is where the top 5 restaurants are pre inputted that will ultimately appear on the index of the website
namespace TopRestaurant.Models
{
    public class Restaurant
    {
        //Putting the rank in the method makes it is passed into the object from the method
        public Restaurant(int rank)
        {
            RestaurantRank = rank;
        }

        public int RestaurantRank { get; }
        public string RestaurantName { get; set; }
        public string FavDish { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string? Website { get; set; } = "Coming Soon";
        //Coming soon will poulate the Website, if jt is not declared for each object.
        
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Taco Bell",
                FavDish = "Doritos Loco Taco",
                Address = "500 Street St. Provo, UT",
                PhoneNum = "801-222-4444",
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Wendy's",
                FavDish = null,
                Address = "1234 Swag St. Provo, UT",
                PhoneNum = "801-321-4444",
                Website = "https://www.wendys.com",
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Whataburger",
                FavDish = "Patty Melt",
                Address = "5569 Main St. Keller, TX",
                PhoneNum = "817-111-5678",
                Website = "https://whataburger.com",
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Maverick",
                FavDish = "Gas Station Sushi",
                Address = "333 University Blvd. Orem, UT",
                PhoneNum = "817-111-5678",
                Website = "https://www.maverik.com",
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "In-n-Out",
                FavDish = "French Fries",
                Address = "500 University Blvd. Orem, UT",
                PhoneNum = "801-222-4321",
                Website = "https://www.in-n-out.com",
            };
            return new Restaurant[] { r1, r2, r3, r4, r5};
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This model handels the class of the user inputted restaurants. It has its own validators to ensure the proper information is received.
namespace TopRestaurant.Models
{
    public class RestaurantResponse
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string FavDish { get; set; }
        [Required]
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}", ErrorMessage ="Phone should be 0-9 and in this format  xxx-xxx-xxxx")]
        public string RestaurantPhone { get; set; }
    }
}

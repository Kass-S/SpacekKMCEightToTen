using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpacekKMCEightToTen.Services;

namespace SpacekKMCEightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantService _restaurantService;

        public RestaurantController(RestaurantService restaurantService){
            _restaurantService = restaurantService;
        }

        [HttpGet]
        [Route("pick/{fastFoodPizzaFoodTruck}")]

        public string RestaurantPicker(string fastFoodPizzaFoodTruck){
            return _restaurantService.RestaurantPicker(fastFoodPizzaFoodTruck);
        }
    }
}
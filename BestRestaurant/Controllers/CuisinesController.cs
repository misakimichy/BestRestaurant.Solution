using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BestRestaurant.Models;

namespace BestRestaurant.Controllers
{
    public class CuisineController : Controller
    {
        [HttpGet("/Cuisine")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
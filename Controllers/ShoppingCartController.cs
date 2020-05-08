using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using howest_movie_shop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using howest_movie_shop.Library.Handlers;
using howest_movie_shop.ViewModels.Movies;

namespace howest_movie_shop.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class ShoppingCartController : Controller
    {
        [Route("Shoppingcart")]
        public IActionResult Shoppingcart()
        {
            ViewBag.ShowCart = true;
            return View();
        }

        [Route("Checkout")]
        public IActionResult Checkout()
        {
            return View();
        }

        [Route("Ticket")]
        public IActionResult Ticket()
        {
            return View();
        }

    }
}
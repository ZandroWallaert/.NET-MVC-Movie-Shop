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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using System.Text.Json;
using Library.Services;
using howest_movie_lib.Library.Models;
using System.Security.Claims;
using System.Numerics;

namespace howest_movie_shop.Controllers
{
    
    public class ShoppingCartController : Controller
    {
        private TicketHandler ticketHandler = new TicketHandler();
        private OrdersHandler ordersHandler = new OrdersHandler();
        List<howest_movie_shop.ViewModels.Movies.MovieViewModel> Movies = new List<MovieViewModel>();

        [Route("Shoppingcart")]
        public IActionResult Shoppingcart()
        {
            ViewBag.ShowCart = true;
            return View();
        }

        [Route("Checkout")]
        public IActionResult Checkout(List<howest_movie_shop.ViewModels.Movies.MovieViewModel> movies)
        {
            Movies = movies;
            return View();
        }

        [HttpPost]
        [Route("Ticket")]
        public IActionResult Ticket(string name)
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            string userId = claim.Value.ToString();
            string digits = new String(userId.Where(Char.IsDigit).ToArray());
            
            ordersHandler.AddOrder(Convert.ToInt64(digits.Substring(0, 10)), DateTime.Now, Request.Form["Street"], Request.Form["City"], Request.Form["Postalcode"], Request.Form["Country"]);
            ordersHandler.AddCustomer(digits.Substring(0, 10), Request.Form["Name"], Request.Form["Street"], Request.Form["City"], Request.Form["Postalcode"], Request.Form["Country"]);
            foreach (var item in Movies)
            {
                double price = item.price;
                ordersHandler.AddOrderDetail(Convert.ToInt32(item.id), Convert.ToDecimal(price));
            }
            Console.WriteLine(Movies);
            string radioResult = Request.Form["PaymentMethod"];
            HttpContext.Session.SetString("Cart", "");
            HttpContext.Session.SetInt32("CartCounter", 0);
            return View(ticketHandler.CreateTicket(name, radioResult));
        }

    }
}

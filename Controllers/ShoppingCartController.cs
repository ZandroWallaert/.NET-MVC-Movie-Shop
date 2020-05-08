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

namespace howest_movie_shop.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class ShoppingCartController : Controller
    {
        private TicketHandler ticketHandler = new TicketHandler();

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

        [HttpPost]
        [Route("Ticket")]
        public IActionResult Ticket(string name)
        {
            string radioResult = Request.Form["PaymentMethod"];
            HttpContext.Session.SetString("Cart", "");
            HttpContext.Session.SetInt32("CartCounter", 0);
            return View(ticketHandler.CreateTicket(name, radioResult));
        }

    }
}

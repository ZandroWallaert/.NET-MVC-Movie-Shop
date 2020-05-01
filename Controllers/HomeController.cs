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


namespace howest_movie_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

            /*
        [AllowAnonymous]-attribute has a higher priority then the [Authorize]-attributes.

        A controller with the [AllowAnonymous] attribute, 
        but with a [Authorized] attributes on a method => the [Authorize] attribute will be ignored.
        */

/* 
        private readonly UserManager<IdentityUser> userManager;


        [Authorize(Roles = "Admin")]
        public IActionResult DoAnAuthorizeAdminThing()
        {
            //...
            return View();
        }

        [Authorize(Roles = "Member")]
        public async Task<IActionResult> DoAnAuthorizeRolesThing()
        {
            //...
            // - get current user (need to be used in an async Task<IActionResult> method, with an await)
            var user = await userManager.GetUserAsync(HttpContext.User);
            //...

            return View();
        } */

    }
}

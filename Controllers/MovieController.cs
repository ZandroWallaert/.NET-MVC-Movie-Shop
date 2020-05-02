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

namespace howest_movie_shop.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;
        private MovieHandler movieHandler = new MovieHandler();

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View(movieHandler.CreateHomepage());
            
        }
        [Route("[action]")]
        public IActionResult Collection()
        {
            return View();
        }

        [Route("[action]")]
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

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
    public class DetailsController : Controller
    {
        private readonly ILogger<DetailsController> _logger;
        private DetailsHandler detailHandler = new DetailsHandler();

        public DetailsController(ILogger<DetailsController> logger)
        {
            _logger = logger;
        }

        [Route("Details/{movieId}")]
        public IActionResult Info(long movieId)
        {
            ViewBag.ShowCart = true;
            string movies = HttpContext.Session.GetString("Movies");
            List<Movies> movieList = JsonSerializer.Deserialize<List<Movies>>(movies);
            int counter = (int)HttpContext.Session.GetInt32("CartCounter");
            return View(detailHandler.CreateInfoPage(movieId, movieList, counter));
        }




    }


}


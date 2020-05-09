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
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;
        private MovieHandler movieHandler = new MovieHandler();
        private SessionService service = new SessionService();
        private List<string> querysAndSorts = new List<string>();

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            ViewBag.ShowCart = true;
            HttpContext.Session.SetString("Movies", JsonSerializer.Serialize(service.AllMovies()));
            HttpContext.Session.SetString("OrderedMovies", JsonSerializer.Serialize(service.AllMovies().OrderBy(movie => movie.Title)));
            string movies = HttpContext.Session.GetString("Movies");
            List<Movies> movieList = JsonSerializer.Deserialize<List<Movies>>(movies);

            HttpContext.Session.SetString("RandomMovie", JsonSerializer.Serialize(service.GetRandomMovie()));
            string randomMovie = HttpContext.Session.GetString("RandomMovie");
            List<Movies> randomMovieList = JsonSerializer.Deserialize<List<Movies>>(randomMovie);

            if (HttpContext.Session.GetInt32("CartCounter") == null){
                HttpContext.Session.SetInt32("CartCounter", 0);
            }
            int counter = (int)HttpContext.Session.GetInt32("CartCounter");

            return View(movieHandler.CreateHomepage(movieList, randomMovieList, counter));

        }
        
        [HttpPost]
        [Route("[action]")]
        public IActionResult Index(string searchString, string sortKey, string sortOrder)
        {
            ViewBag.ShowCart = true;

            querysAndSorts.Add(searchString+","+sortKey+","+sortOrder);
            HttpContext.Session.SetString("QueryAndSorts", JsonSerializer.Serialize(querysAndSorts));

            string movies = HttpContext.Session.GetString("Movies");
            List<Movies> movieList = JsonSerializer.Deserialize<List<Movies>>(movies);
            string randomMovie = HttpContext.Session.GetString("RandomMovie");
            List<Movies> randomMovieList = JsonSerializer.Deserialize<List<Movies>>(randomMovie);
            int counter = (int)HttpContext.Session.GetInt32("CartCounter");

            return View(movieHandler.CreateSearch(searchString, sortKey, sortOrder, movieList, randomMovieList, counter));
        }

        [Route("[action]")]
        public IActionResult Collection()
        {
            ViewBag.ShowCart = true;
            return View();
        }

        [Route("[action]")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

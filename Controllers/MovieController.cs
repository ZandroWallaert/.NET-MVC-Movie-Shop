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

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Movies", JsonSerializer.Serialize(service.AllMovies()));
            string movies = HttpContext.Session.GetString("Movies");
            List<Movies> movieList = JsonSerializer.Deserialize<List<Movies>>(movies);

            HttpContext.Session.SetString("RandomMovie", JsonSerializer.Serialize(service.GetRandomMovie()));
            string randomMovie = HttpContext.Session.GetString("RandomMovie");
            List<Movies> randomMovieList = JsonSerializer.Deserialize<List<Movies>>(randomMovie);

            return View(movieHandler.CreateHomepage(movieList, randomMovieList));

        }
        
        [HttpPost]
        [Route("[action]")]
        public IActionResult Index(string searchString, string sortKey, string sortOrder)
        {
            string movies = HttpContext.Session.GetString("Movies");
            List<Movies> movieList = JsonSerializer.Deserialize<List<Movies>>(movies);
            return View(movieHandler.CreateSearch(searchString, sortKey, sortOrder, movieList));
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

        private List<string> StoreSearchQuery(string query)
    {
        // Add the search string to the session state to remember it.
        List<string> previousQueries = GetPreviousQueries();

        if (!previousQueries.Contains(query))
        {
            previousQueries.Add(query);
        }

        // Overwrite the current searchQueries with the new results.
        HttpContext.Session.SetString("searchQueries", JsonSerializer.Serialize(previousQueries));

        return previousQueries;
    }
  
    private List<string> GetPreviousQueries()
    {
        // Get the raw json from the session store.
        string previousQueriesJson = HttpContext.Session.GetString("searchQueries");
        List<string> previousQueries = new List<string>();

        if (!string.IsNullOrEmpty(previousQueriesJson))
        {
            // When the searchQueries key is available deserialize into a list of strings.
            previousQueries = JsonSerializer.Deserialize<List<string>>(previousQueriesJson);
        }

        return previousQueries;
    } 

    }
}

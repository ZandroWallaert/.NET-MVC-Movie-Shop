using System;
using System.Linq;
using System.Collections.Generic;
using howest_movie_lib.Library.Services;
using System.Collections;
using howest_movie_lib.Library.Models;
using howest_movie_shop.ViewModels.Movies;

namespace howest_movie_shop.Library.Handlers
{
    public class MovieHandler
    {
        private MovieService service = new MovieService();

        public MoviesViewModel CreateHomepage()
        {
            var randomMovie = service.GetRandomMovie();

            MoviesViewModel page = new MoviesViewModel
            {
                RandomMovie = new MovieViewModel
                {
                    title = randomMovie.Title,
                    id = randomMovie.Id,
                    year = randomMovie.Year,
                    coverUrl = randomMovie.CoverUrl
                },
                Search = "",
                Queries = new List<string>(),
                Movies = new List<MovieViewModel>()
            };

            foreach (var movie in service.AllMovies())
            {
                MovieViewModel movieViewModel = new MovieViewModel
                {
                    title = movie.Title,
                    id = movie.Id,
                    year = movie.Year,
                    coverUrl = movie.CoverUrl
                };

                page.Movies.Add(movieViewModel);
            }
            return page;
        }
    }
}

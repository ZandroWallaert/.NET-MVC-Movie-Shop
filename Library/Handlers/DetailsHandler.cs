using System;
using System.Linq;
using System.Collections.Generic;
using howest_movie_lib.Library.Services;
using System.Collections;
using howest_movie_lib.Library.Models;
using howest_movie_shop.ViewModels.Movies;

namespace howest_movie_shop.Library.Handlers
{
    public class DetailsHandler
    {
        private MovieService movieService = new MovieService();
        private DetailService detailService = new DetailService();
        private GenreService genreService = new GenreService();
        List<String> actors = new List<string>();

        public DetailViewModel CreateInfoPage(long movieId)
        {
            foreach (var movie in movieService.AllMovies().Where(s => s.Id == movieId))
            {
                DetailViewModel page = new DetailViewModel
                {
                    title = movie.Title,
                    movieId = movie.Id,
                    year = movie.Year,
                    coverUrl = movie.CoverUrl,
                    rating = movie.Rating,
                    genre = detailService.GetGenres(movieId),
                    plot = movie.Plot,
                    Actors = detailService.GetActors(movieId)
                };
                return page;
            }
            DetailViewModel empty = new DetailViewModel { };
            return empty;
        }
    }
}

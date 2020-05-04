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
        List<String> actors = new List<string>();

        public DetailViewModel CreateInfoPage(long movieId)
        {
            foreach (var movie in movieService.AllMovies().Where(s => s.Id == movieId))
            {
                foreach (var person in detailService.GetActorName(movie.Title))
                {
                    actors.Add(person.Name);
                };

                DetailViewModel page = new DetailViewModel
                {
                    title = movie.Title,
                    movieId = movie.Id,
                    year = movie.Year,
                    coverUrl = movie.CoverUrl,
                    rating = movie.Rating,
                    genreID = detailService.GetGenreId(movie.Id),
                    genre = detailService.GetGenreName(detailService.GetGenreId(movie.Id)),
                    plot = movie.Plot,
                    Actors = actors
                };
                return page;
            }
            DetailViewModel empty = new DetailViewModel{};
            return empty;
        }

    }
}

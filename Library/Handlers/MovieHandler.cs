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

        public MoviesViewModel CreateSearch(String searchString, String sortKey, String sortOrder)
        {
            var randomMovie = service.GetRandomMovie();
            MoviesViewModel searchPage = new MoviesViewModel
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
            if (searchString == null)
            {
                if (sortKey.Equals("title") && sortOrder.Equals("asc"))
                {
                    foreach (var movie in service.AllMovies().OrderBy(i => i.Title))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Search = searchString;
                        searchPage.Queries.Add(searchString);
                    }
                }
                if (sortKey.Equals("year") && sortOrder.Equals("asc"))
                {
                    foreach (var movie in service.AllMovies().OrderBy(i => i.Year))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Search = searchString;
                        searchPage.Queries.Add(searchString);
                    }
                }
                if (sortKey.Equals("title") && sortOrder.Equals("desc"))
                {
                    foreach (var movie in service.AllMovies().OrderByDescending(i => i.Title))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Search = searchString;
                        searchPage.Queries.Add(searchString);
                    }
                }
                if (sortKey.Equals("year") && sortOrder.Equals("desc"))
                {
                    foreach (var movie in service.AllMovies().OrderByDescending(i => i.Year))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Search = searchString;
                        searchPage.Queries.Add(searchString);
                    }
                }
            }
            else
            {
                if (sortKey.Equals("title") && sortOrder.Equals("asc"))
                {
                    foreach (var movie in service.AllMovies().OrderBy(i => i.Title).Where(s => s.Title.ToLower().Contains(searchString)))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Search = searchString;
                        searchPage.Queries.Add(searchString);
                    }
                }
                if (sortKey.Equals("year") && sortOrder.Equals("asc"))
                {
                    foreach (var movie in service.AllMovies().OrderBy(i => i.Year).Where(s => s.Title.ToLower().Contains(searchString)))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Search = searchString;
                        searchPage.Queries.Add(searchString);
                    }
                }
                if (sortKey.Equals("title") && sortOrder.Equals("desc"))
                {
                    foreach (var movie in service.AllMovies().OrderByDescending(i => i.Title).Where(s => s.Title.ToLower().Contains(searchString)))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Search = searchString;
                        searchPage.Queries.Add(searchString);
                    }
                }
                if (sortKey.Equals("year") && sortOrder.Equals("desc"))
                {
                    foreach (var movie in service.AllMovies().OrderByDescending(i => i.Year).Where(s => s.Title.ToLower().Contains(searchString)))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Search = searchString;
                        searchPage.Queries.Add(searchString);
                    }
                }
            }
            return searchPage;
        }
    }
}

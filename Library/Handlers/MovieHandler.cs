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
        private MainService service = new MainService();
        private Int32 allMoviesCount = new Int32();
        public List<string> Queries = new List<string>();
        private IEnumerable<Movies> moviesIE;

        public MoviesViewModel CreateHomepage(List<Movies> movies, List<Movies> RandomMovie, int counter)
        {
            moviesIE = movies;
            allMoviesCount = moviesIE.Count();
            var randomMovie = RandomMovie.First();

            MoviesViewModel page = new MoviesViewModel
            {
                RandomMovie = new MovieViewModel
                {
                    title = randomMovie.Title,
                    id = randomMovie.Id,
                    year = randomMovie.Year,
                    coverUrl = randomMovie.CoverUrl
                },
                Movies = new List<MovieViewModel>(),
                SortKey = service.GetSortKey(),
                SortOrder = service.GetSortOrder(),
                CartCounter = counter
            };

            foreach (var movie in moviesIE)
            {
                MovieViewModel movieViewModel = new MovieViewModel
                {
                    title = movie.Title,
                    id = movie.Id,
                    year = movie.Year,
                    coverUrl = movie.CoverUrl,
                    price = 9.99
                };

                page.Movies.Add(movieViewModel);
                page.Count = allMoviesCount;
            }
            return page;
        }

        public MoviesViewModel CreateSearch(String searchString, String sortKey, String sortOrder, List<Movies> movies, List<Movies> RandomMovie, int counter)
        {
            moviesIE = movies;
            var randomMovie = RandomMovie.First();
            MoviesViewModel searchPage = new MoviesViewModel
            {
                RandomMovie = new MovieViewModel
                {
                    title = randomMovie.Title,
                    id = randomMovie.Id,
                    year = randomMovie.Year,
                    coverUrl = randomMovie.CoverUrl,
                    price = 9.99
                },
                Movies = new List<MovieViewModel>(),
                SortKey = service.GetSortKey(),
                SortOrder = service.GetSortOrder(),
                CartCounter = counter
            };
            if (searchString == null)
            {
                Queries.Add("emtpy" + " " + sortKey + " " + sortOrder);
                if (sortKey.Equals("title") && sortOrder.Equals("asc"))
                {
                    foreach (var movie in moviesIE.OrderBy(i => i.Title))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl,
                            price = 9.99
                        };
                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Count = moviesIE.Count();
                    }
                }
                if (sortKey.Equals("year") && sortOrder.Equals("asc"))
                {
                    foreach (var movie in moviesIE.OrderBy(i => i.Year))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl,
                            price = 9.99
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Count = moviesIE.Count();
                    }
                }
                if (sortKey.Equals("title") && sortOrder.Equals("desc"))
                {
                    foreach (var movie in moviesIE.OrderByDescending(i => i.Title))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl,
                            price = 9.99
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Count = moviesIE.Count();
                    }
                }
                if (sortKey.Equals("year") && sortOrder.Equals("desc"))
                {
                    foreach (var movie in moviesIE.OrderByDescending(i => i.Year))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl,
                            price = 9.99
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Count = moviesIE.Count();
                    }
                }
            }
            else
            {
                Queries.Add(searchString + " " + sortKey + " " + sortOrder);
                if (sortKey.Equals("title") && sortOrder.Equals("asc"))
                {
                    foreach (var movie in moviesIE.OrderBy(i => i.Title).Where(s => s.Title.ToLower().Contains(searchString)))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl,
                            price = 9.99
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Count = moviesIE.OrderBy(i => i.Title).Where(s => s.Title.ToLower().Contains(searchString)).Count();
                    }
                }
                if (sortKey.Equals("year") && sortOrder.Equals("asc"))
                {
                    foreach (var movie in moviesIE.OrderBy(i => i.Year).Where(s => s.Title.ToLower().Contains(searchString)))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl,
                            price = 9.99
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Count = moviesIE.OrderBy(i => i.Year).Where(s => s.Title.ToLower().Contains(searchString)).Count();
                    }
                }
                if (sortKey.Equals("title") && sortOrder.Equals("desc"))
                {
                    foreach (var movie in moviesIE.OrderByDescending(i => i.Title).Where(s => s.Title.ToLower().Contains(searchString)))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl,
                            price = 9.99
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Count = moviesIE.OrderByDescending(i => i.Title).Where(s => s.Title.ToLower().Contains(searchString)).Count();
                    }
                }
                if (sortKey.Equals("year") && sortOrder.Equals("desc"))
                {
                    foreach (var movie in moviesIE.OrderByDescending(i => i.Year).Where(s => s.Title.ToLower().Contains(searchString)))
                    {
                        MovieViewModel movieViewModel = new MovieViewModel
                        {
                            title = movie.Title,
                            id = movie.Id,
                            year = movie.Year,
                            coverUrl = movie.CoverUrl,
                            price = 9.99
                        };

                        searchPage.Movies.Add(movieViewModel);
                        searchPage.Count = moviesIE.OrderByDescending(i => i.Year).Where(s => s.Title.ToLower().Contains(searchString)).Count();
                    }
                }
            }
            return searchPage;
        }
    }
}


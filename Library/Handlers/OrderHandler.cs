using System;
using System.Linq;
using System.Collections.Generic;
using howest_movie_lib.Library.Services;
using System.Collections;
using howest_movie_lib.Library.Models;
using howest_movie_shop.ViewModels.Movies;

namespace howest_movie_shop.Library.Handlers
{
    public class OrderHandler
    {
        private IEnumerable<OrderViewModel> cartIE;
        public MoviesViewModel CreateOrderPage(List<OrderViewModel> cart)
        {
            cartIE = cart;
            MoviesViewModel page = new MoviesViewModel
            {
                Movies = new List<MovieViewModel>()
            };
            double sum = 0; 
            foreach (var movie in cartIE)
            {
                MovieViewModel movieViewModel = new MovieViewModel
                {
                    title = movie.Movie.First().Title
                };
                page.Movies.Add(movieViewModel);
                page.price = 9.99;
                sum += page.price;
            }
            page.CartCounter = cartIE.Count();
            page.sum = sum;
            return page;
        }
    }
}


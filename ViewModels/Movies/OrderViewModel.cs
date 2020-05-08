using System;
using System.Collections.Generic;

namespace howest_movie_shop.ViewModels.Movies
{
    public class OrderViewModel
    {
        public IEnumerable<howest_movie_lib.Library.Models.Movies> Movie { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 CartCounter { get; set; }
    }

}

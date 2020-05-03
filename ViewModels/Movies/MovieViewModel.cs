using System;
using System.Collections.Generic;

namespace howest_movie_shop.ViewModels.Movies
{
    public class MovieViewModel
    {
        public String title { get; set; }
        public Int32 year { get; set; }
        public long id { get; set; }
        public String coverUrl { get; set; }
    }

}

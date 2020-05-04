using System;
using System.Collections.Generic;

namespace howest_movie_shop.ViewModels.Movies
{
    public class DetailViewModel
    {
        public String title { get; set; }
        public Int32 year { get; set; }
        public long movieId { get; set; }
        public String coverUrl { get; set; }
        public int genreID { get; set; }
        public String genre { get; set; }
        public String plot { get; set; }
        public decimal rating { get; set; }
        public List<string> Actors { get; set; }
    }

}

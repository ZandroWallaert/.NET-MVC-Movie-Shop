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
        public List<howest_movie_lib.Library.Models.Genres> genre { get; set; }
        public String plot { get; set; }
        public decimal rating { get; set; }
        public List<howest_movie_lib.Library.Models.Persons> Actors { get; set; }
    }

}

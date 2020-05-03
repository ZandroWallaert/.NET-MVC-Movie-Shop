using System;
using System.Collections.Generic;

namespace howest_movie_shop.ViewModels.Movies {
    public class MoviesViewModel{
        public String title { get; set; }
        public Int32 year { get; set; }
        public long id { get; set; }
        public String coverUrl { get; set; }
        public MovieViewModel RandomMovie { get; internal set; }
        public List<MovieViewModel> Movies { get; internal set; }
        public List<string> Queries { get; internal set; }
        public string Search { get; internal set; }
        public Int32 Count { get; internal set; }
    }

}

using System;
using System.Collections;
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
        public Int32 Count { get; internal set; }
        public List<string> SortKey { get; set;}
        public List<string> SortOrder { get; set;}
        public double price { get; set;}
        public double sum { get; set;}
        public Int32 CartCounter { get; set; }
    }

}

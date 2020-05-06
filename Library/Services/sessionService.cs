using System.Collections.Generic;
using howest_movie_lib.Library.Models;
using System.Linq;
using System;

namespace Library.Services
{
    public class SessionService
    {
      db_moviesContext context = new db_moviesContext();

        public List<Movies> AllMovies()
        {
            return context.Movies.ToList();
        }

        public List<Movies> GetRandomMovie()
        {
            Random r = new Random();
            int rInt = r.Next(1, 250);
            return (from t in AllMovies() where t.Id.Equals(rInt) select t).ToList();
        }
    
        
    }
}


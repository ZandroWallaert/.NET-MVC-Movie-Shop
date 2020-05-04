using System.Web;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json;

namespace Library.Services
{
    public class SessionService
    {
        
    /* private List<string> StoreSearchQuery(string query)
    {
        // Add the search string to the session state to remember it.
        List<string> previousQueries = GetPreviousQueries();

        if (!previousQueries.Contains(query))
        {
            previousQueries.Add(query);
        }

        // Overwrite the current searchQueries with the new results.
        HttpContext.Session.SetString("searchQueries", JsonSerializer.Serialize(previousQueries));

        return previousQueries;
    }

    private List<string> GetPreviousQueries()
    {
        // Get the raw json from the session store.
        string previousQueriesJson = HttpContext.Session.GetString("searchQueries");
        List<string> previousQueries = new List<string>();

        if (!string.IsNullOrEmpty(previousQueriesJson))
        {
            // When the searchQueries key is available deserialize into a list of strings.
            previousQueries = JsonSerializer.Deserialize<List<string>>(previousQueriesJson);
        }

        return previousQueries;
    }

    private object StoreMovies(object movies) {
        object storedMovies = movies;
        HttpContext.Session.SetString("movies", JsonSerializer.Serialize(storedMovies));
        return storedMovies;
    }

    private object GetMovies() {
        object moviesJson = HttpContext.Session.GetString("movies");
        object movies = new object();
        movies = JsonSerializer.Deserialize<object>((string)moviesJson);
        return movies;
    } */
}
}


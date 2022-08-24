using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Helpers
{
    public class RepoInMemory: IRepo
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie> ()
            {
                new Movie(){Title = "Spider-Man: Far From Home", RealeaseDate = new DateTime(2019, 7, 2)},
                new Movie(){Title = "Moana", RealeaseDate = new DateTime(2016, 11, 23)},
                new Movie(){Title = "Inception", RealeaseDate = new DateTime(2019, 7, 16)}
            };
        }
        
    }

}
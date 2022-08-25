using BlazorMovies.Client;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;


namespace BlazorMovies.Client.Pages
{

    public partial class Counter
    {
        [Inject] SingletonService singleton {get; set;}
        [Inject] TransientService transient {get; set;}
        public int currentCount {get; set;}

        private List<Movie> movies;
        protected override void OnInitialized()
        {
            movies = new List<Movie>()
            {
                new Movie(){Title = "Joker", RealeaseDate = new DateTime(2019, 7, 2)},
                new Movie(){Title = "Avengers", RealeaseDate = new DateTime(2016, 11, 23)}
            }
        }

        public void IncrementCount()
        {
            currentCount ++;
        }

    }

}


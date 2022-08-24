using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Helpers 
{

    public interface IRepo
    {
        List<Movie> GetMovies();
    }

}
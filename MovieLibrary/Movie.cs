using System;
using System.Collections.Generic;

namespace MovieLibrary
{
    public abstract class Movie
    {
        // public properties
        public UInt64 movieId { get; set; }
        public string title { get; set; }
        public List<string> genres { get; set; }

        // constructor
        public Movie()
        {
            genres = new List<string>();
        }

        // public method
        public string DisplayMovie()
        {
            return $"ID: {movieId}\nTitle: {title}\nGenres: {string.Join(", ", genres)}\n";
        }


    }
}

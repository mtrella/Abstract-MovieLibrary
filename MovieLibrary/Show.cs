using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Show : Movie
    {
        public UInt64 showId { get; set; }
        public string title { get; set; }
        public UInt64 season { get; set; }
        public UInt64 episode { get; set; }
        public List<string> writers { get; set; }

        public Show()
        {
            writers = new List<string>();
        }

        public string Display()
        {
            return $"ID: {showId}\nTitle: {title}\nSeason: {season}\nEpisode: {episode}\nWriters: {string.Join(", ", writers)}\n";
        }
    }
}
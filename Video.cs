using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Video : Movie
    {
        public UInt64 videoId { get; set; }
        public string title { get; set; }
        public string format { get; set; }
        public UInt64 length { get; set; }
        public List<UInt64> regions { get; set; }

        public Video()
        {
            regions = new List<UInt64>();
        }

        public string Display()
        {
            return $"ID: {videoId}\nTitle: {title}\nFormat: {format}\nLength: {length}\nRegions: {string.Join(", ", regions)}\n";
        }
    }
}
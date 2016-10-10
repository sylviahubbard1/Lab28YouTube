using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab28YouTube.Models
{
    public class YouTubeModel
    {
        public string Keywords
        {
            get;set;
        }
        public List<string> Videos { get; set; }
        public List<string> Channels { get; set; }
        public List<string> Playlists { get; set; }

        public YouTubeModel()
        {
            Videos = new List<string>();
            Channels = new List<string>();
            Playlists = new List<string>();
        }
    }
}
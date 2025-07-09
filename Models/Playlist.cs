using System.Collections.Generic;

namespace MusicPlayer.Models
{
    public class Playlist : BaseModel
    {
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }

        public Playlist(string name)
        {
            Name = name;
            Tracks = new List<Track>();
        }
    }
}

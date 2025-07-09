using System.Collections;
using System.Collections.Generic;
using MusicPlayer.Models;

namespace MusicPlayer.Collections
{
    public class TrackCollection : IEnumerable<Track>
    {
        private List<Track> tracks = new List<Track>();

        public void Add(Track track) => tracks.Add(track);
        public void Remove(Track track) => tracks.Remove(track);

        public IEnumerator<Track> GetEnumerator() => tracks.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

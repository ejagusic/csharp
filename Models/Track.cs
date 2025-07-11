using System;
using MusicPlayer.Interfaces;

namespace MusicPlayer.Models
{
    public class Track : BaseModel, IPlayable
    {
        public required string Title { get; set; }
        public required string Artist { get; set; }
        public required string FilePath { get; set; }

        public override string ToString() => $"{Title} - {Artist}";

        public virtual void Play(){
        }

        public virtual void Pause(){
        }

        public virtual void Stop(){
        }
    }
}

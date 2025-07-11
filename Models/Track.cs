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

<<<<<<< HEAD
        public virtual void Play(){}

        public virtual void Pause(){}

        public virtual void Stop(){}
=======
        public virtual void Play()
        {
        }

        public virtual void Pause()
        {
        }

        public virtual void Stop()
        {
        }
>>>>>>> 4ff8049ec91d730d1ba18c1f213351234d1cfaea
    }
}

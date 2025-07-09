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

        public virtual void Play()
        {
            // Implementation handled by AudioPlayer
        }

        public virtual void Pause()
        {
            // Implementation handled by AudioPlayer
        }

        public virtual void Stop()
        {
            // Implementation handled by AudioPlayer
        }
    }
}

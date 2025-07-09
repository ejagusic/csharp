using System;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MusicPlayer.Helpers
{
    public class AudioPlayer
    {
        private NAudio.Wave.WaveOutEvent? outputDevice;
        private NAudio.Wave.AudioFileReader? audioFile;
        private bool isPlaying = false;

        public bool IsPlaying => isPlaying;
        public void Play(string filePath)
        {
            if (audioFile != null && outputDevice != null && audioFile.FileName == filePath && isPlaying)
            {
                return;
            }
            if (audioFile != null && outputDevice != null && audioFile.FileName == filePath && !isPlaying)
            {
                outputDevice.Play();
                isPlaying = true;
                return;
            }

            Stop();
            audioFile = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();
            isPlaying = true;
            outputDevice.PlaybackStopped += (s, e) => isPlaying = false;
        }

        public void Pause()
        {
            outputDevice?.Pause();
            isPlaying = false;
        }

        public void Stop()
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            outputDevice = null;
            audioFile?.Dispose();
            audioFile = null;
            isPlaying = false;
        }

        public int GetProgressPercent()
        {
            if (audioFile == null) return 0;
            return (int)((audioFile.CurrentTime.TotalSeconds / audioFile.TotalTime.TotalSeconds) * 100);
        }

        public float Volume
        {
            get => audioFile?.Volume ?? 1.0f;
            set
            {
                if (audioFile != null)
                    audioFile.Volume = value;
            }
        }

    }
}

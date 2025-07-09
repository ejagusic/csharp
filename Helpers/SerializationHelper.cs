using System.IO;
using System.Text.Json;
using MusicPlayer.Models;

namespace MusicPlayer.Helpers
{
    public static class SerializationHelper
    {
        public static void SavePlaylist(Playlist playlist, string filePath)
        {
            var json = JsonSerializer.Serialize(playlist);
            File.WriteAllText(filePath, json);
        }

        public static Playlist? LoadPlaylist(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Playlist>(json);
        }
    }
}

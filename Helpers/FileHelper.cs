using System.IO;

namespace MusicPlayer.Helpers
{
    public static class FileHelper
    {
        public static bool FileExists(string path) => File.Exists(path);
        public static string ReadAllText(string path) => File.ReadAllText(path);
        public static void WriteAllText(string path, string content) => File.WriteAllText(path, content);
    }
}

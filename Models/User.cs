namespace MusicPlayer.Models
{
    public class User : BaseModel
    {
        public required string Username { get; set; }
        public required string Email { get; set; }

    }
}

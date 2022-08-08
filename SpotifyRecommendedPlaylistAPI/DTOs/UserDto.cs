using System;

namespace SpotifyRecommendedPlaylistAPI.DTOs
{
    public class UserDto
    {
        public Int32 UserID { get; set; }
        public String Name { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }

        public String Phone { get; set; }
    }
}

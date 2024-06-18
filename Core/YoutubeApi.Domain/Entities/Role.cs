using Microsoft.AspNetCore.Identity;


namespace YoutubeApi.Domain.Entities
{
    public class Role:IdentityRole<Guid>
    {
        public string FullName { get; set; }
        public string? RefreshToken{ get; set; }
        public string? RefreshTokenExpiryTime { get; set; }

    }
}

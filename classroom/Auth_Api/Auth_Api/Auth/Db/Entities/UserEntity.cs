using Microsoft.AspNetCore.Identity;

namespace Auth_Api.Auth.Db.Entities
{
    public class UserEntity : IdentityUser<int>
    {
        public string? GoogleId { get; set; }
        public string? ProfilePictureUrl { get; set; }
    }
}

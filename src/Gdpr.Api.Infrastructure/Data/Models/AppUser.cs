using Gdpr.Api.Infrastructure.Data.Entities;

namespace Gdpr.Api.Infrastructure.Data.Models
{
    public class AppUser : BaseEntity
    {
        public AppUser(string firstName, string lastName, string email, string passwordHash, string id, int role)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            Id = id;
            Role = role;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int Role { get; set; }
    }
}
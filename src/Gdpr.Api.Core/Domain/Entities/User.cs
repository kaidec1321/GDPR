namespace Gdpr.Api.Core.Domain.Entities
{
    public class User
    {
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string PasswordHash { get; }
        public int Role { get; set; }

        public User(string firstName, string lastName, string email, int role, string id = null, string passwordHash = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
        }
    }
}
namespace BTH8.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public UserProfile Profile { get; set; } = null!;

        public List<Post> Posts { get; set; } = new();

        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
    }
}

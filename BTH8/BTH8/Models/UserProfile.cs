namespace BTH8.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;

        // Quan hệ 1-1 với User
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}

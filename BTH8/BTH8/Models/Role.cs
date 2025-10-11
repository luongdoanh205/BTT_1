namespace BTH8.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Admin, User, etc.

        // Một Role có nhiều User
        public List<User> Users { get; set; } = new();
    }
}

namespace BTH8.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Người đăng bài
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        // Một bài có nhiều bình luận
        public List<Comment> Comments { get; set; } = new();
    }
}

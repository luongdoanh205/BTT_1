namespace BTH8.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Người bình luận
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        // Bài viết được bình luận
        public int PostId { get; set; }
        public Post Post { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Demo1.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public string? PostDesc { get; set; }
    }
}

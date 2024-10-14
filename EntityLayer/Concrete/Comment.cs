using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }
        public int UserID { get; set; }
        public User User { get; set; } = null!;
        public int PostID { get; set; }
        public Post Post { get; set; } = null!;
    }
}

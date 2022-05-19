using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rolling_Tavern.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        [Required(ErrorMessage = "Поле {0} є обов'язковим.")]
        [StringLength(1000, ErrorMessage = "{0} повиннa бути не менше {2} та не більше {1} літер", MinimumLength = 1)]
        public string CommentContent { get; set; }
        public DateTime DateOfComment { get; set; }
        public long? AuthorId { get; set; }
        public int? MeetingId { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}

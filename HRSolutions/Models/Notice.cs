using System.ComponentModel.DataAnnotations;

namespace HRSolutions.Models
{
    public class Notice
    {
        [Key]
        public int NoticeId { get; set; }

        public string Title { get; set; }
        public string Auther { get; set; }
        public string Description { get; set; }
    }
}

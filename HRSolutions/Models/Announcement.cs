using System.ComponentModel.DataAnnotations;

namespace HRSolutions.Models
{
    public class Announcement
    {
        [Key]
        public string announcementId { get; set; }
        public string? announcementTitle { get; set; } // Allow null
        public string? description { get; set; }
    }
}

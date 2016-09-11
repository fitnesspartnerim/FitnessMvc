using System.ComponentModel.DataAnnotations;

namespace FitnessMvc.ViewModels
{
    public class TodoViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public bool IsCompleted { get; set; }
    }
}
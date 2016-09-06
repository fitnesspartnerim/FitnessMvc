using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessMvc.Models
{
    [Table("Todos")]
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
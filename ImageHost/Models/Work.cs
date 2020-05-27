using System;
using System.ComponentModel.DataAnnotations;

namespace ImageHost.Models
{
    public class Work
    {
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime DateUploaded { get; set; }

        [Required]
        public virtual ApplicationUser Author { get; set; }
    }
}
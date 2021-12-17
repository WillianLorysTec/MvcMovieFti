using System.ComponentModel.DataAnnotations;

namespace MvcMovieFti.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedDateMovie { get; set;}

        [Required]
        [DataType(DataType.Date)] 
        public DateTime CreatedDateBD { get; set; }

        [Required]
        public int DurationInMinutes { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}

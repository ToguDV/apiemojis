using System.ComponentModel.DataAnnotations;

namespace apiemojis.Models
{
    public class Trivia
    {
        [Key]
        public int TriviaId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [MaxLength(200)]
        public string Emojis { get; set; }
    }
}

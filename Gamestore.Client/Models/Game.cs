using System.ComponentModel.DataAnnotations;

namespace Gamestore.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        [Required]
        [StringLength(15)]
        public required string Genre { get; set; }
        [Required]
        [Range(1, 100)]
        public decimal Price { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}
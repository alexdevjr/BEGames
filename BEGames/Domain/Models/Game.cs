using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BEGames.Domain.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academia2025.Models
{
    public class Treino
    {
        [Key]
        public short IdTreino { get; set; }

        [Required]
        [ForeignKey("Membro")]
        public short FkIdMembro { get; set; }
        public required Membro Membro { get; set; }

        [Required]
        [StringLength(50)]
        public required string Tipo { get; set; }

        [Required]
        [StringLength(200)]
        public string? Descricao { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }
    }
}
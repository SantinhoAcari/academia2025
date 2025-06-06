using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academia2025.Models
{
    public class Treino
    {
        [Key]
        public int IdTreino { get; set; }

        [Required]
        public int FkIdMembro { get; set; }

        [ForeignKey(nameof(FkIdMembro))]
        public required Membro Membro { get; set; }

        [Required]
        [StringLength(50)]
        public required string Tipo { get; set; }

        [StringLength(200)]
        public string? Descricao { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }
    }
}

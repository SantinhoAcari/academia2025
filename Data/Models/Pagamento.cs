using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academia2025.Models
{
    public class Pagamento
    {
        [Key]
        public short IdPagamento { get; set; }

        [Required]
        [ForeignKey("Membro")]
        public short FkIdMembro { get; set; }
        public required Membro Membro { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }

        [Required]
        public DateTime DataPagamento { get; set; }

        [Required]
        [StringLength(20)]
        public required string StatusPagamento { get; set; } 
    }
}
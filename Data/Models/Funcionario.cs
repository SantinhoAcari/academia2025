using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academia2025.Models
{
    public class Funcionario
    {
        [Key]
        public short IdFuncionario { get; set; }

        [Required]
        [StringLength(50)]
        public required string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public required string Cargo { get; set; }

        [Required]
        [StringLength(50)]
        public required string Login { get; set; }

        [Required]
        [StringLength(50)]
        public required string Senha { get; set; }

        [ForeignKey("Historico")]
        public short? FkIdHistorico { get; set; }
        public required Historico Historico { get; set; }
    }
}
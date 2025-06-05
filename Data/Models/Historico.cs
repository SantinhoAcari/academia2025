using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academia2025.Models
{
    public class Historico
    {
        [Key]
        public short IdHistorico { get; set; }

        [Required]
        [ForeignKey("Membro")]
        public short FkIdMembro { get; set; }
        public required Membro Membro { get; set; }

        [Required]
        [StringLength(30)]
        public required string Atividade { get; set; }

        [Required]
        public DateTime DataAtividade { get; set; }

        [Required]
        public int TempoExecucao { get; set; }

        [Required]
        [ForeignKey("Funcionario")]
        public required Funcionario Funcionario { get; set; }
    }
}
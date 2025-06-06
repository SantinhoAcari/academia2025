using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academia2025.Models
{
    public class Historico
    {
        [Key]
        public int IdHistorico { get; set; }

        [Required]
        public int FkIdMembro { get; set; }

        [ForeignKey("FkIdMembro")]
        public required Membro Membro { get; set; }

        [Required]
        [StringLength(30)]
        public required string Atividade { get; set; }

        [Required]
        public DateTime DataAtividade { get; set; }

        [Required]
        public int TempoExecucao { get; set; }

        [Required]
        public int FkIdFuncionario { get; set; }

        [ForeignKey("FkIdFuncionario")]
        public required Funcionario Funcionario { get; set; }
    }
}

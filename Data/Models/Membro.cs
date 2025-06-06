using System.ComponentModel.DataAnnotations;

namespace Academia2025.Models
{
    public class Membro
    {
        [Key]
        public int IdMembro { get; set; }

        [Required, StringLength(50)]
        public required string Nome { get; set; }

        [Required, StringLength(11)]
        public required string CPF { get; set; }

        [Required, StringLength(11)]
        public required string Telefone { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public ICollection<Historico>? Historicos { get; set; }
    }
}

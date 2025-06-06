using Academia2025.Models;
using System.ComponentModel.DataAnnotations;

namespace Academia2025.Models
{
    public class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }

        [Required, StringLength(50)]
        public required string Nome { get; set; }

        [Required, StringLength(50)]
        public required string Cargo { get; set; }

        [Required, StringLength(50)]
        public required string Login { get; set; }

        [Required, StringLength(50)]
        public required string Senha { get; set; }

        public ICollection<Historico>? Historicos { get; set; }
    }
}

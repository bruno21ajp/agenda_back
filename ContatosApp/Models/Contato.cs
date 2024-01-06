using System.ComponentModel.DataAnnotations;

namespace ContatosApp.Models
{
    public class Contato
    {
        public int? Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        public string? Telefone { get; set; }
    }
}

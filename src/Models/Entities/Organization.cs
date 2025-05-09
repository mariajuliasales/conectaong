using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace conectaOng.Models.Entities
{
    public class Organization
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(50)]
        public string Categoria { get; set; }

        public string Descricao { get; set; }

        // FK para User
        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        // 🔗 Relação 1:N com Events
        public ICollection<Event> Events { get; set; } = new List<Event>();

    }
}
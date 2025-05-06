using System.ComponentModel.DataAnnotations;

namespace conectaOng.Models
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "O título é obrigatório.")]
        [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A data é obrigatória.")]
        [DataType(DataType.Date, ErrorMessage = "A data deve estar em um formato válido.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "A localização é obrigatória.")]
        [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "O ID da organização é obrigatório.")]
        public int OrganizationId { get; set; }
    }
}
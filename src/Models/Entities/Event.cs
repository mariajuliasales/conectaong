using System.ComponentModel.DataAnnotations;

namespace conectaOng.Models.Entities
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres.")]
        public string Title { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Event), nameof(ValidateFutureDate))]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres.")]
        public string Location { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }

        public List<Volunteer> Volunteers { get; set; }

        public static ValidationResult ValidateFutureDate(DateTime date, ValidationContext context)
        {
            if (date < DateTime.Now)
            {
                return new ValidationResult("A data do evento deve ser no futuro.");
            }
            return ValidationResult.Success;
        }
    }
}
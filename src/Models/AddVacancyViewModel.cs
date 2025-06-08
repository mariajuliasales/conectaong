using System;
using System.ComponentModel.DataAnnotations;

namespace conectaOng.Models
{
    public class AddVacancyViewModel
    {
        public Guid? EventId { get; set; }
        public Guid? OrganizationId { get; set; }

        [Required(ErrorMessage = "O voluntário é obrigatório.")]
        public Guid VolunteerId { get; set; }

        [Required(ErrorMessage = "A data de inscrição é obrigatória.")]
        [DataType(DataType.DateTime)]
        public DateTime RegisteredAt { get; set; }

        [Required(ErrorMessage = "Informe se foi aceito ou não.")]
        public bool Accepted { get; set; }
    }
}
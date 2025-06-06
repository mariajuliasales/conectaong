using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conectaOng.Models.Entities
{
    public class Vacancy
    {
        [Key]
        public Guid Id { get; set; }

        public Guid? EventId { get; set; }
        [ForeignKey("EventId")]
        public Event? Event { get; set; }

        public Guid? OrganizationId { get; set; }
        [ForeignKey("OrganizationId")]
        public Organization? Organization { get; set; }

        [Required]
        public Guid VolunteerId { get; set; }
        [ForeignKey("VolunteerId")]
        public Volunteer Volunteer { get; set; }

        [Required]
        public DateTime RegisteredAt { get; set; }

        [Required]
        public bool Accepted { get; set; }

        public ICollection<Vacancy> Volunteers { get; set; }
    }
}
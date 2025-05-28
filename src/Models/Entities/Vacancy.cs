namespace conectaOng.Models.Entities
{
    public class Vacancy
    {
        public int EventId { get; set; }
        public required Event Event { get; set; }
        public int VolunteerId { get; set; }
        public required Volunteer Volunteer { get; set; }

        public DateTime RegisteredAt { get; set; }

    }
}

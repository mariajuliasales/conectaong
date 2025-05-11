using conectaOng.Models.Enums;

namespace conectaOng.Models
{
    public class AddVolunteerViewModel
    {
        public string Name { get; set; }

        public string Cpf { get; set; }

        public Sex Sex { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }

    }
}

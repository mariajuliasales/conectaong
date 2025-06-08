using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace conectaOng.Models.Entities
{
    public class Organization
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }   
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using conectaOng.Models.Enums;

namespace conectaOng.Models.Entities
{
    [Table("Volunteer")]
    public class Volunteer
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o CPF!")]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o sexo!")]
        public Sex Sex { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        public string Password { get; set; }
    }
}

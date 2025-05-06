namespace conectaOng.Models
{
    public class AddOrganizationViewModel
    {
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public Guid UserId { get; set; }
    }
}
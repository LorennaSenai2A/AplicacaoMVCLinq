namespace AplicacaoMVCLinq.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int RM { get; set; }


        public Cliente(int id, string nome, string email, int rm)
        {
            this.ClienteId = id;
            this.Nome = nome;
            this.Email = email;
            this.RM = rm;
        }
    }
}

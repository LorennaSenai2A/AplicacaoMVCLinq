namespace AplicacaoMVCLinq.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public DateOnly DataNasc { get; set; }


        public Cliente(int id, string nome, string email, int telefone, DateOnly data)
        {
            this.ClienteId = id;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.DataNasc = data;
        }
    }
}

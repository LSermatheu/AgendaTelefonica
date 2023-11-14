namespace AgendaTelefonicaBackEnd.DAO.contatos
{
    public class ContatosDTO
    {
        public virtual int contatoId { get; set; }
        public virtual string contatoNome { get; set; } = string.Empty;
        public virtual string contatoTelefone1 { get; set; } = string.Empty;
        public virtual string contatoTelefone2 { get; set; } = string.Empty;
        public virtual string contatoEndereco { get; set; } = string.Empty;
        public virtual DateTime contatoDtNascimento { get; set; } = DateTime.Now;
        public virtual bool contatoAtivo { get; set; } = true;
    }
}

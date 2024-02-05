using AgendaTelefonica.Shared.ViewModels;

namespace AgendaTelefonica.API.Dao
{
    public class ContatoDTO
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; } = string.Empty;
        public virtual string TelefoneCelular { get; set; } = string.Empty;
        public virtual string TelefoneFixo { get; set; } = string.Empty;
        public virtual string Endereco { get; set; } = string.Empty;
        public virtual UF Estado { get; set; } = (UF)25;
        public virtual DateTime DataNacimento { get; set; } = DateTime.Today;
        public virtual bool Ativo { get; set; } = true;
    }
}

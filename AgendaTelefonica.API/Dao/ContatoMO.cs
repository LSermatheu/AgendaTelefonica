using AgendaTelefonica.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AgendaTelefonica.API.Dao
{
    public class ContatoMO : ContatoVM
    {
        public ContatoMO() { }
        public ContatoMO(ContatoDTO dto)
        {
            Id = dto.Id;
            Nome = dto.Nome;
            TelefoneCelular = dto.TelefoneCelular;
            TelefoneFixo = dto.TelefoneFixo;
            Endereco = dto.Endereco;
            Estado = dto.Estado;
            DataNacimento = dto.DataNacimento;
            Ativo = dto.Ativo;
        }
    }
}

using NHibernate.Linq;

namespace AgendaTelefonica.BackEnd.DAO.contatos
{
    public class ContatosDAO : _connect.DAOBase<ContatosDTO>
    {
        public Contato? Get(int id)
        {
            Contato? retorno = null;
            var dto = GetByKey(id);
            if (dto != null)
            {
                retorno = new Contato(dto);
            }
            return retorno;
        }

        public List<Contato> List(string filter = "")
        {
            var retorno = new List<Contato>();

            var lista = ListByExpression(e => e.contatoNome.Contains(filter) && e.contatoAtivo, o => o.contatoId);
            foreach (var item in lista)
            {
                retorno.Add(new Contato(item));
            }

            return retorno;
        }

        public bool Save(Contato obj)
        {
            var dto = GetByKey(obj.id) ?? new ContatosDTO();

            // Atualizo os dados do obj na tabela
            dto.contatoNome = obj.nome;
            dto.contatoTelefone1 = obj.telefone1;
            dto.contatoTelefone2 = obj.telefone2;
            dto.contatoEndereco = obj.endereco;
            dto.contatoDtNascimento = obj.dtNascimento;
            dto.contatoAtivo = obj.ativo;
            return SaveObject(dto);
        }

        public bool Delete(int id)
        {
            bool result = false;
            var dto = GetByKey(id);

            if(dto!= null)
            {
                dto.contatoAtivo = false;
                result = SaveObject(dto);
            }

            return result;
        }

    }

}

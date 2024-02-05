using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;

namespace AgendaTelefonica.API.Dao
{
    public class ContatoMAP : ClassMap<ContatoDTO>
    {
        public ContatoMAP()
        {
            Table("contatos");

            Id(x => x.Id);

            Map(x => x.Nome);
            Map(x => x.TelefoneCelular);
            Map(x => x.TelefoneFixo);
            Map(x => x.Endereco);
            Map(x => x.Estado);
            Map(x => x.DataNacimento);
            Map(x => x.Ativo);
        }
    }
}

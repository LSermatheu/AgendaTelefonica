namespace AgendaTelefonica.BackEnd.DAO.contatos
{
    using FluentNHibernate.Mapping;

    public class ContatosMAP : ClassMap<ContatosDTO>
    {
        public ContatosMAP()
        {
            Table("contatos");

            Id(x => x.contatoId);

            Map(x => x.contatoNome);
            Map(x => x.contatoTelefone1);
            Map(x => x.contatoTelefone2);
            Map(x => x.contatoEndereco);
            Map(x => x.contatoDtNascimento);
            Map(x => x.contatoAtivo);

        }
    }
}



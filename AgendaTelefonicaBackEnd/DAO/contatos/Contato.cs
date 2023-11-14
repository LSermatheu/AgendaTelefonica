namespace AgendaTelefonicaBackEnd.DAO.contatos
{
    public class Contato : AgendaTelefonicaModel.Contato
        //Entender o pq da aplicação não conseguir enxergar a Model
    {
        public Contato(ContatosDTO dto)
        {
            id = dto.contatoId;

        }
    }
}

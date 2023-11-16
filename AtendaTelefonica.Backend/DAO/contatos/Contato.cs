namespace AgendaTelefonica.BackEnd.DAO.contatos
{
    public class Contato : AgendaTelefonicaModel.Contato
    {
        public Contato() { }

        public Contato(ContatosDTO dto)
        {
            id = dto.contatoId;
            nome = dto.contatoNome;
            telefone1 = dto.contatoTelefone1;
            telefone2 = dto.contatoTelefone2;
            endereco = dto.contatoEndereco;
            dtNascimento = dto.contatoDtNascimento;
            ativo = dto.contatoAtivo;

        }
    }
}

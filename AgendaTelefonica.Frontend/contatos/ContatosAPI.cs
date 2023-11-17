using AgendaTelefonicaModel;

namespace AgendaTelefonica.Frontend.contatos
{
    internal class ContatosAPI : ApiConnect
    {
        const string command = "contatos";

        public List<Contato>? LIST(string filtro = "")
        {
            return CallApi<List<Contato>>(CallType.Get, $"{command}/list/{filtro}");
        }

        public Contato? GET(int id)
        {
            return CallApi<Contato>(CallType.Get, $"{command}/{id}");
        }

        public bool SAVE(Contato? cadastro)
        {
            bool result = false;
            if (cadastro != null)
            {
                result = CallApi<bool>(CallType.Post, command, cadastro);
            }

            return result;
        }

        public bool DELETE(int id)
        {
            return CallApi<bool>(CallType.Delete, $"{command}/{id}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaTelefonica.Shared.ViewModels
{
    public class ContatoVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneFixo { get; set; }
        public string Endereco { get; set; }
        public UF Estado { get; set; } = (UF)25;
        public DateTime? DataNacimento { get; set; }
        public bool Ativo { get; set; } = true;

        public string AtivoDescricao
        {
            get {
                if (Ativo)
                    return "Sim";
                else
                    return "Não";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonicaModel
{
    public class Contato
    {
        public int id { get; set; }
        public string nome { get; set; } = string.Empty;
        public string telefone1 { get; set; } = string.Empty;
        public string telefone2 { get; set; } = string.Empty;
        public string endereco { get; set; } = string.Empty;
        public DateTime dtNascimento { get; set; } = DateTime.Now;
        public bool ativo { get; set; } = true;
    }
}

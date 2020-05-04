using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Endereco
    {
        public int Id_Endereco { get; set; }
        public Pessoa Pessoa { get; set; }
        public string Logradouro { get; set; }
        public Int16 Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}

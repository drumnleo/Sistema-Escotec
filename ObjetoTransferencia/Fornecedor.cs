using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Fornecedor
    {
        public int Id_Fornecedor { get; set; }
        public string CNPJ { get; set; }
        public string Inscricao_Est { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }
        public string Email { get; set; }
        public string Razao_Social { get; set; }
        public string Contato { get; set; }
        public string Observacao { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultimo_Cadastro { get; set; }
        public Usuario Usuario { get; set; }

    }
}
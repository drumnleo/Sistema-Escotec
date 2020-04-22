using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Pessoa
    {
        public int Id_Pessoa { get; set; }
        public Profissao Profissao { get; set; }
        public TipoDoc TipoDoc { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Telefone Telefone { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Doc { get; set; }
        public DateTime Data_Nasc { get; set; }
        public string Email { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public string Sexo { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }


    }
}

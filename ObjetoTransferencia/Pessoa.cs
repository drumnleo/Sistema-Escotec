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
        public int Id_Profissao { get; set; }
        public int Id_TipoDoc { get; set; }
        public int Id_EstadoCivil { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Doc { get; set; }
        public DateTime Data_Nasc { get; set; }
        public string Email { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }
        public Char Sexo { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }


    }
}

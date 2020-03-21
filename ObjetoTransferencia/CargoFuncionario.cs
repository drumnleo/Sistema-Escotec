using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class CargoFuncionario
    {
        public int Id_Cargo_Funcionario { get; set; }
        public Cargo Cargo { get; set; }
        public Funcionario Funcionario { get; set; }
        public decimal Salario { get; set; }
        public bool Comissao { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}

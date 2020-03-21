using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class CargoFuncionarioHistorico
    {
        public int Id_Historico_Cf { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime Date_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
    }
}

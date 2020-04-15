using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Orcamento
    {
        
        public int Id_Orcamento { get; set; }
        public Pessoa Pessoa { get; set; }
        public PromocaoValor PromocaoValor { get; set; }
        public Turma Turma1 { get; set; }
        public decimal Valor_Entrada_Turma_1 { get; set; }
        public decimal Valor_DemaisParcelas_Turma_1 { get; set; }
        public Turma Turma2 { get; set; }
        public decimal Valor_Entrada_Turma_2 { get; set; }
        public decimal valor_DemaisParcelas_Turma_2 { get; set; }
        public DateTime Validade_Orcamento { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario_Cad_Alt { get; set; }
        public Boolean Aprovado { get; set; }
        public Usuario Aprovado_Usuario { get; set; }
        public string Comentario_Aprovacao { get; set; }
        public bool Ativo { get; set; }

    }
}

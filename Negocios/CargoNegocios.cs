using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBandoDados;
using ObjetoTransferencia;
using System.Data;
namespace Negocios
{
    public class CargoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Inserir

        public string Inserir(Cargo cargo)
        {
            try
            { 
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_USUARIO", cargo.Usuario.Id_Usuario) ;
                acessoDados.AdicionarParametros("@DESCRICAO", cargo.Descricao);


               string IdCargo = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_CARGO_INSERIR").ToString();

               return IdCargo;
            }
            catch (Exception ex)
            {

                return ex.Message;
                
            }
        }

        public CargoColecao ConsultarPorNome(string nome)
        {
            try
            {

                CargoColecao cargoColecao = new CargoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DESCRICAO", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CARGO_CONSULTAR_PORDESCRICAO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Cargo cargo = new Cargo();

                    cargo.Id_Cargo = Convert.ToInt32(dataRow["ID_CARGO"]);
                    cargo.Descricao = Convert.ToString(dataRow["DESCRICAO"]);
                    cargo.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    cargo.Data_Ultima_Altercao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    cargo.Usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO"]);

                    cargoColecao.Add(cargo);    

                }

                return cargoColecao;


            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar Cargo. Detalhes" + ex.Message);
            }
        }
        public string Excluir(Cargo cargo)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CARGO", cargo.Id_Cargo);
                acessoDados.AdicionarParametros("@ID_USUARIO", cargo.Usuario.Id_Usuario);
                string id_cargo = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_CARGO_EXCLUIR").ToString();
                return id_cargo;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

    }
}





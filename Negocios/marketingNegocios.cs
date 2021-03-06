﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBandoDados;
using ObjetoTransferencia;
using System.Data;
namespace Negocios
{
    public class MarketingNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Inserir

        public string Inserir(Marketing marketing)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DESCRICAO", marketing.Descricao);
                acessoDados.AdicionarParametros("@ID_USUARIO", marketing.Usuario.Id_Usuario);

                string IdMarketing = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_MARKETING_INSERIR").ToString();

                return IdMarketing;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarporId(Marketing marketing)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_MKT", marketing.Id_Mkt);
                acessoDados.AdicionarParametros("@DESCRICAO", marketing.Descricao);
                acessoDados.AdicionarParametros("@ID_USUARIO", marketing.Usuario.Id_Usuario);

                string IdMarketing = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_MARKETING_ATUALIZARPORID").ToString();

                return IdMarketing;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public MarketingColecao ConsultarPorDescricao(string nome)
        {
            try
            {
                MarketingColecao marketingColecao = new MarketingColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DESCRICAO", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TIPO_MARKETING_CONSULTAPORDESCRICAO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Marketing marketing = new Marketing();

                    marketing.Id_Mkt = Convert.ToInt32(dataRow["ID_MKT"]);
                    marketing.Descricao = Convert.ToString(dataRow["DESCRICAO"]);
                    marketing.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    marketing.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    marketing.Usuario = usuario;

                    marketingColecao.Add(marketing);
                }
                return marketingColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar marketing. Detalhes" + ex.Message);
            }
        }
        public MarketingColecao ConsultarPorId(int id)
        {
            try
            {
                MarketingColecao marketingColecao = new MarketingColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_MKT", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TIPO_MARKETING_CONSULTAPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Marketing marketing = new Marketing();

                    marketing.Id_Mkt = Convert.ToInt32(dataRow["ID_MKT"]);
                    marketing.Descricao = Convert.ToString(dataRow["DESCRICAO"]);
                    marketing.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    marketing.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    marketing.Usuario = usuario;

                    marketingColecao.Add(marketing);
                }
                return marketingColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar marketing. Detalhes" + ex.Message);
            }
        }
        public string Excluir(Marketing marketing)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_MKT", marketing.Id_Mkt);
                acessoDados.AdicionarParametros("@ID_USUARIO", marketing.Usuario.Id_Usuario);
                string idMarketing = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_MARKETING_EXCLUIR").ToString();
                return idMarketing;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}



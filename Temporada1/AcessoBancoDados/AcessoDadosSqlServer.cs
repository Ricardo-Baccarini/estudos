using AcessoBancoDados.Properties;
using System;
// Namespace´s que contém as classes que manipulam dados.
using System.Data;
using System.Data.SqlClient;
namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        // Cria a Conexão
        private SqlConnection CriaConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        // Parâmetros que vão para o Banco de Dados
        private SqlParameterCollection sqlParameterColletion = new SqlCommand().Parameters;
        public void LimparParametros()
        {
            sqlParameterColletion.Clear();
        }

        public void AdicionarParametros(string NomeParametro, object ValorParametro)
        {
            sqlParameterColletion.Add(new SqlParameter(NomeParametro, ValorParametro));
        }
        // Persistência - Inserir, Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType, string NomeStoredProcedureOuTextoSql)
        {
            try
            {
                // Cria Conexao
                SqlConnection sqlConnection = CriaConexao();
                // Abre a Conexão
                sqlConnection.Open();
                // Cria comando que leva informação ao Banco de Dados.
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                // Coloca no Comanado as "coisas" que irão para o Banco de dados.
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = NomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;

                // Adiciona os Parametros no Comando
                foreach (SqlParameter sqlParameter in sqlParameterColletion)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                // Executa o comando, ou seja, manda o Comando até o banco de dados
                return sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Consultar registro do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string NomeStoredProcedureOuTextoSql)
        {
            try
            {
                // Cria Conexao
                SqlConnection sqlConnection = CriaConexao();
                // Abre a Conexão
                sqlConnection.Open();
                // Cria comando que leva informação ao Banco de Dados.
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                // Coloca no Comanado as "coisas" que irão para o Banco de dados.
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = NomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;

                // Adiciona os Parametros no Comando
                foreach (SqlParameter sqlParameter in sqlParameterColletion)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                // Cria o Adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Cria a Tabela de Dados Vazia onde vou colocar os dados que vem do banco.
                DataTable dataTable = new DataTable();
                // Manda o comando até o banco busca os dados e preenche o datatable
                sqlDataAdapter.Fill(dataTable);
                
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}

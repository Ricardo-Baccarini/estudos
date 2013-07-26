using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class ClienteNegocios
    {
        // Instanciar; Criar um novo Objeto baseado em um modelo.
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Método para inserir cliente
        public string Inserir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.LimiteCompra);
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idCliente", cliente.idCliente);
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.LimiteCompra);
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "[uspClienteAlterar").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Excluir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idCliente", cliente.idCliente);
                return acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ClienteColecao ConsultarPorNome(string Nome)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", Nome);
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                // Percorre o dataTableCliente e transforma em uma coleção de clientes
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.idCliente = Convert.ToInt32( linha["idCliente"] );
                    cliente.Nome = linha["Nome"].ToString();
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);
                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar clientes. Detalhes: " + ex.Message);
            }
        }

        public ClienteColecao ConsultarPorId(int idCliente)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@idCliente", idCliente);
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorId");

                // Percorre o dataTableCliente e transforma em uma coleção de clientes
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.idCliente = Convert.ToInt32(linha["idCliente"]);
                    cliente.Nome = linha["Nome"].ToString();
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);
                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar clientes. Detalhes: " + ex.Message);
            }
        }
    }
}

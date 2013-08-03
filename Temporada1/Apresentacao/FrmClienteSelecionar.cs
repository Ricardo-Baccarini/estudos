using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar()
        {
            InitializeComponent();

            // Linhas da Grade
            dataGridViewPrincipal.AutoGenerateColumns = false;

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxPesquisa.Text != "")
            {
                AtualizarGrid();
            }
        }

        private void AtualizarGrid()
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            string nomeCliente = textBoxPesquisa.Text;

            ClienteColecao clienteColecao = new ClienteColecao();
            clienteColecao = clienteNegocios.ConsultarPorNome(nomeCliente);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = clienteColecao;
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não há registro selecionado.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o registro?",
                                                     "Atenção",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            // Pega o Cliente Selecionado no Grid.
            Cliente clienteSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            //Instanciar a Regra de Negócio
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            //Chama o método excluir.
            string retorno = clienteNegocios.Excluir(clienteSelecionado);

            // Se o retorno for um número é sinal que a exclusão foi bem sucedida.
            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente excluído com sucesso.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir o cliente. Erro: " + retorno, "Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            // Instancia o formulário de cadastro.
            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Inserir);

            frmCadastrar.ShowDialog();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            // Instancia o formulário de cadastro.
            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Alterar);

            frmCadastrar.ShowDialog();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            // Instancia o formulário de cadastro.
            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Consultar);

            frmCadastrar.ShowDialog();
        }
    }
}

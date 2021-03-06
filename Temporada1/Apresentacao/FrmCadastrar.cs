﻿using System.Windows.Forms;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmCadastrar : Form
    {
        private void HablilitarEdicao(AcaoNaTela acaoNaTela)
        {
            this.textBoxNome.ReadOnly = (acaoNaTela == AcaoNaTela.Consultar);
            this.textBoxNome.TabStop = (acaoNaTela != AcaoNaTela.Consultar);
            this.textBoxLimiteCompra.ReadOnly = (acaoNaTela == AcaoNaTela.Consultar);
            this.textBoxLimiteCompra.TabStop = (acaoNaTela != AcaoNaTela.Consultar);
            this.dateNascimento.Enabled = !(acaoNaTela == AcaoNaTela.Consultar);
            this.dateNascimento.TabStop = (acaoNaTela != AcaoNaTela.Consultar);
            this.radioSexoFeminino.Enabled = !(acaoNaTela == AcaoNaTela.Consultar);
            this.radioSexoFeminino.TabStop = (acaoNaTela != AcaoNaTela.Consultar);
            this.radioSexoMasculino.Enabled = !(acaoNaTela == AcaoNaTela.Consultar);
            this.radioSexoMasculino.TabStop = (acaoNaTela != AcaoNaTela.Consultar);
            this.buttonSalvar.Visible = !(acaoNaTela == AcaoNaTela.Consultar);
            if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.buttonCancelar.Text = "&Fechar";
                this.buttonCancelar.Focus();
            }
            else
                this.buttonCancelar.Text = "&Cancelar";
        }

        private void CarregarTela(Cliente cliente)
        {
            this.Text = "Alterar Cliente";
            this.textBoxCodigo.Text = cliente.idCliente.ToString();
            this.textBoxNome.Text = cliente.Nome;
            this.textBoxLimiteCompra.Text = cliente.LimiteCompra.ToString("#,##0.00");
            this.dateNascimento.Value = cliente.DataNascimento;
            if (cliente.Sexo == false)
            {
                this.radioSexoFeminino.Checked = true;
            }
            else
            {
                this.radioSexoMasculino.Checked = true;
            }
        }

        //Construtor
        public FrmCadastrar( AcaoNaTela acaoNaTela, Cliente cliente )
        {
            InitializeComponent();
           
            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Cliente";
                HablilitarEdicao(acaoNaTela);
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                CarregarTela(cliente);
                HablilitarEdicao(acaoNaTela);
                //this.Text = "Alterar Cliente";
                //this.textBoxCodigo.Text = cliente.idCliente.ToString();
                //this.textBoxNome.Text = cliente.Nome;
                //this.textBoxLimiteCompra.Text = cliente.LimiteCompra.ToString("#,##0.00");
                //this.dateNascimento.Value = cliente.DataNascimento;
                //if (cliente.Sexo == false)
                //{
                //    this.radioSexoFeminino.Checked = true;
                //}
                //else
                //{
                //    this.radioSexoMasculino.Checked = true;
                //}
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Cliente";
                CarregarTela(cliente);
                HablilitarEdicao(acaoNaTela);
            }
        }

        private void buttonCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

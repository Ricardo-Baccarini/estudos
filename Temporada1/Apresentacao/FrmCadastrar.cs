using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmCadastrar : Form
    {
        //Construtor
        public FrmCadastrar( AcaoNaTela acaoNaTela )
        {
            InitializeComponent();
           
            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Cliente";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Cliente";
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Cliente";
            }
        }
    }
}

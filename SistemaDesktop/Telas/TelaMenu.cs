using SistemaDesktop.Modelo;
using System;
using System.Windows.Forms;
namespace SistemaDesktop
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        {


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enviado!!");
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void criarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblBemVindo.Visible = false;
            txtNome.Visible = true;
            txtCpf.Visible = true;
            txtIDArea.Visible = true;
            txtUsuario.Visible = true;
            lblNome.Visible = true;
            lblCpf.Visible = true;
            lblIdArea.Visible = true;
            lblUsuario.Visible = true;
            btnEnviar.Visible = true;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            CriarUser cad = new CriarUser();
            String mensagem = cad.cadastro(txtNome.Text, txtCpf.Text, txtIDArea.Text, txtUsuario.Text);
            if (cad.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(cad.mensagem);//mensagem de erro
            }

            Limpar limpa = new Limpar();
            limpa.LimpaCampos(this.Controls);
        }
    }
}

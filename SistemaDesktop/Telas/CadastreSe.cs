using SistemaDesktop.Modelo;
using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
using System.Windows.Forms;

namespace SistemaDesktop.Telas
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtEmail.Text, txtSenha.Text, txtConfSenha.Text);
            if (controle.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro
            }

            Limpar limpa = new Limpar();
            limpa.LimpaCampos(this.Controls);
        }
    }
}

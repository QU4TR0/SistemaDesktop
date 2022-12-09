<<<<<<< HEAD
﻿using SistemaDesktop.DAO;
using SistemaDesktop.Modelo;
using System;
using System.Security.Cryptography.X509Certificates;
=======
﻿using SistemaDesktop.Modelo;
using System;
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
using System.Windows.Forms;
namespace SistemaDesktop
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
<<<<<<< HEAD
            lblBemVindo.Visible = true;
            pnlModificarUser.Visible = false;
            pnlCriarUser.Visible = false;
            pnlCriarProd.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
=======
        }

        {

>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            MessageBox.Show("Enviado!!");
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void criarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            pnlCriarUser.Visible = true;
            txtNome.Visible = true;
            txtCpf.Visible = true;
            txtIDArea.Visible = true;
            txtEmail.Visible = true;
            lblNome.Visible = true;
            lblCpf.Visible = true;
            lblIdArea.Visible = true;
            lblEmail.Visible = true;
            btnEnviar.Visible = true;
            pnlModificarUser.Visible = false;
            lblBemVindo.Visible = false;
=======
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
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            CriarUser cad = new CriarUser();
<<<<<<< HEAD
            String mensagem = cad.cadastro(txtNome.Text, txtCpf.Text, txtIDArea.Text, txtEmail.Text);
=======
            String mensagem = cad.cadastro(txtNome.Text, txtCpf.Text, txtIDArea.Text, txtUsuario.Text);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
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
<<<<<<< HEAD

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void modificarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlModificarUser.Visible = true;
            pnlCriarUser.Visible = false;
            pnlCriarProd.Visible = false;
            txtEmail.Visible = true;
            lblEmail.Visible = true;
            btnBuscar.Visible = true;
            btnBuscarExc.Visible = false;
            lblBemVindo.Visible = false;
        }

        private void pnlCriarUser_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ModificarUser busca = new ModificarUser();
            busca.buscar(txtEmailBusca.Text);

            if (busca.mensagem.Equals(""))
            {
                if (busca.tem)
                {
                    MessageBox.Show("Encontrado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailMod.Visible = true;
                    txtEmailMod.Text = busca.emailMod;
                    txtNomeMod.Text = busca.nome;
                    txtCpfMod.Text = busca.cpf;
                    txtIdMod.Text = Convert.ToString(busca.idArea);
                    btnMod.Visible = true;
                    btnExcluir.Visible = true;
                }
                else
                {
                    MessageBox.Show("Não Encontrado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            ModificarUser modificar = new ModificarUser();
            String mensagem = modificar.salvarAlteracoes(txtNomeMod.Text, txtCpfMod.Text, Convert.ToInt32(txtIdMod.Text), txtEmailMod.Text, txtEmailBusca.Text);
            if (modificar.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailMod.Visible = false;
                btnMod.Visible = false;
                Limpar limpar = new Limpar();
                limpar.LimpaCampos(this.Controls);
            }
            else
            {
                MessageBox.Show(modificar.mensagem);//mensagem de erro
            }

            
        }

        private void excluirUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlModificarUser.Visible = true;
            pnlCriarUser.Visible = false;
            txtEmail.Visible = true;
            lblEmail.Visible = true;
            btnMod.Visible = false;
            btnExcluir.Visible = false;
            btnBuscar.Visible = false;
            btnBuscarExc.Visible = true;
            lblBemVindo.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ModificarUser exclui = new ModificarUser();
            String mensagem = exclui.excluir(txtEmailMod.Text);
            if (exclui.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailMod.Visible = false;
                btnMod.Visible = false;
            }
            else
            {
                MessageBox.Show(exclui.mensagem);//mensagem de erro
            }

            Limpar limpar = new Limpar();
            limpar.LimpaCampos(this.Controls);
        }

        private void btnBuscarExc_Click(object sender, EventArgs e)
        {
            ModificarUser busca = new ModificarUser();
            busca.buscar(txtEmailBusca.Text);

            if (busca.mensagem.Equals(""))
            {
                if (busca.tem)
                {
                    MessageBox.Show("Encontrado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailMod.Visible = true;
                    txtEmailMod.Text = busca.emailMod;
                    txtNomeMod.Text = busca.nome;
                    txtCpfMod.Text = busca.cpf;
                    txtIdMod.Text = Convert.ToString(busca.idArea);
                    btnMod.Visible = false;
                    btnExcluir.Visible = true;
                }
                else
                {
                    MessageBox.Show("Não Encontrado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void criarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCriarProd.Visible = true;
            pnlModificarUser.Visible = false;
            pnlCriarUser.Visible = false;
            lblIdProd.Visible = true;
            lblNomeProd.Visible = true;
            lblMarcaProd.Visible = true;
            lblPrecoProd.Visible = true;
            txtIdProd.Visible = true;
            txtNomeProd.Visible = true;
            txtMarcaProd.Visible = true;
            txtPrecoProd.Visible = true;
            btnSalvarProd.Visible = true;
            lblBemVindo.Visible = false;
        }

        private void btnLimparUser_Click(object sender, EventArgs e)
        {
            Limpar limpar = new Limpar();
            limpar.LimpaCampos(this.Controls);
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            CriarProd cadProd = new CriarProd();
            String mensagem = cadProd.cadastro(Convert.ToInt32(txtIdProd.Text), txtNomeProd.Text, txtMarcaProd.Text, txtPrecoProd.Text);
            if (cadProd.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(cadProd.mensagem);//mensagem de erro
            }
        }

        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            ModificarProd exclui = new ModificarProd();
            String mensagem = exclui.excluir(txtIdProd.Text);
            if (exclui.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProdMod.Visible = false;
                btnModProd.Visible = false;
                btnExcluirProd.Visible = true;
            }
            else
            {
                MessageBox.Show(exclui.mensagem);//mensagem de erro
            }
        }

        private void btnAlteracoesProd_Click(object sender, EventArgs e)
        {
            ModificarProd modificar = new ModificarProd();
            String mensagem = modificar.salvarAlteracoes(txtNomeProd.Text, txtMarcaProd.Text, txtPrecoProd.Text, Convert.ToInt32(txtIdProdMod.Text), Convert.ToInt32(txtIdProd.Text));
            if (modificar.tem)//mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProdMod.Visible = false;
                btnModProd.Visible = false;
                btnExcluirProd.Visible = false;
            }
            else
            {
                MessageBox.Show(modificar.mensagem);//mensagem de erro
            }
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            ModificarProd busca = new ModificarProd();
            busca.buscar(Convert.ToInt32(txtIdProd.Text));

            if (busca.mensagem.Equals(""))
            {
                if (busca.tem)
                {
                    MessageBox.Show("Encontrado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdProdMod.Visible = true;
                    txtIdProdMod.Text = Convert.ToString(busca.idProdMod);
                    txtIdProdMod.Visible = true;
                    lblNomeProd.Visible = true;
                    lblMarcaProd.Visible = true;
                    lblPrecoProd.Visible = true;
                    txtNomeProd.Visible = true;
                    txtMarcaProd.Visible = true;
                    txtPrecoProd.Visible = true;
                    btnModProd.Visible = true;
                    txtNomeProd.Text = busca.nomeProd;
                    txtMarcaProd.Text = busca.marcaProd;
                    txtPrecoProd.Text = busca.precoProd;
                    btnExcluirProd.Visible = true;
                }
                else
                {
                    MessageBox.Show("Não Encontrado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void modificarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlModificarUser.Visible = false;
            pnlCriarUser.Visible = false;
            pnlCriarProd.Visible = true;
            txtIdProd.Visible = true;
            lblIdProd.Visible = true;
            btnModProd.Visible = false;
            btnExcluirProd.Visible = false;
            btnBuscarProd.Visible = true;
            lblBemVindo.Visible = false;
            lblNomeProd.Visible = false;
            lblMarcaProd.Visible = false;
            lblPrecoProd.Visible = false;
            txtNomeProd.Visible = false;
            txtMarcaProd.Visible = false;
            txtPrecoProd.Visible = false;
        }

        private void excluirProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlModificarUser.Visible = false;
            pnlCriarUser.Visible = false;
            pnlCriarProd.Visible = true;
            txtIdProd.Visible = true;
            lblIdProd.Visible = true;
            btnModProd.Visible = false;
            btnSalvarProd.Visible = false;
            btnExcluirProd.Visible = false;
            btnBuscarProd.Visible = true;
            lblBemVindo.Visible = false;
            lblNomeProd.Visible = false;
            lblMarcaProd.Visible = false;
            lblPrecoProd.Visible = false;
            txtNomeProd.Visible = false;
            txtMarcaProd.Visible = false;
            txtPrecoProd.Visible = false;
        }
=======
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
    }
}

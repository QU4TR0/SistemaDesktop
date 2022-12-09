<<<<<<< HEAD
﻿using System.Windows.Forms;

namespace SistemaDesktop
{
    partial class TelaMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblIdArea = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtIDArea = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnlModificarUser = new System.Windows.Forms.Panel();
            this.txtEmailMod = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            this.lblIdMod = new System.Windows.Forms.Label();
            this.txtCpfMod = new System.Windows.Forms.TextBox();
            this.lblCpfMod = new System.Windows.Forms.Label();
            this.txtNomeMod = new System.Windows.Forms.TextBox();
            this.lblNomeMod = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEmailBusca = new System.Windows.Forms.Label();
            this.txtEmailBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarExc = new System.Windows.Forms.Button();
            this.pnlCriarProd = new System.Windows.Forms.Panel();
            this.txtIdProdMod = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.btnModProd = new System.Windows.Forms.Button();
            this.txtPrecoProd = new System.Windows.Forms.TextBox();
            this.lblPrecoProd = new System.Windows.Forms.Label();
            this.txtMarcaProd = new System.Windows.Forms.TextBox();
            this.lblMarcaProd = new System.Windows.Forms.Label();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.btnSalvarProd = new System.Windows.Forms.Button();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.pnlCriarUser = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlModificarUser.SuspendLayout();
            this.pnlCriarProd.SuspendLayout();
            this.pnlCriarUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProdutosToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.menu1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuProdutosToolStripMenuItem
            // 
            this.menuProdutosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarProdutosToolStripMenuItem,
            this.modificarProdutosToolStripMenuItem,
            this.excluirProdutosToolStripMenuItem});
            this.menuProdutosToolStripMenuItem.Name = "menuProdutosToolStripMenuItem";
            this.menuProdutosToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.menuProdutosToolStripMenuItem.Text = "Menu Produtos";
            // 
            // criarProdutosToolStripMenuItem
            // 
            this.criarProdutosToolStripMenuItem.Name = "criarProdutosToolStripMenuItem";
            this.criarProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.criarProdutosToolStripMenuItem.Text = "Criar Produtos";
            this.criarProdutosToolStripMenuItem.Click += new System.EventHandler(this.criarProdutosToolStripMenuItem_Click);
            // 
            // modificarProdutosToolStripMenuItem
            // 
            this.modificarProdutosToolStripMenuItem.Name = "modificarProdutosToolStripMenuItem";
            this.modificarProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.modificarProdutosToolStripMenuItem.Text = "Modificar Produtos";
            this.modificarProdutosToolStripMenuItem.Click += new System.EventHandler(this.modificarProdutosToolStripMenuItem_Click);
            // 
            // excluirProdutosToolStripMenuItem
            // 
            this.excluirProdutosToolStripMenuItem.Name = "excluirProdutosToolStripMenuItem";
            this.excluirProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.excluirProdutosToolStripMenuItem.Text = "Excluir Produtos";
            this.excluirProdutosToolStripMenuItem.Click += new System.EventHandler(this.excluirProdutosToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarUsuárioToolStripMenuItem,
            this.modificarUsuárioToolStripMenuItem,
            this.excluirUsuárioToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            // 
            // criarUsuárioToolStripMenuItem
            // 
            this.criarUsuárioToolStripMenuItem.Name = "criarUsuárioToolStripMenuItem";
            this.criarUsuárioToolStripMenuItem.Text = "Criar Usuário";
            this.criarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.criarUsuárioToolStripMenuItem_Click);
            // 
            // modificarUsuárioToolStripMenuItem
            // 
            this.modificarUsuárioToolStripMenuItem.Name = "modificarUsuárioToolStripMenuItem";
            this.modificarUsuárioToolStripMenuItem.Text = "Modificar Usuário";
            this.modificarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuárioToolStripMenuItem_Click);
            // 
            // excluirUsuárioToolStripMenuItem
            // 
            this.excluirUsuárioToolStripMenuItem.Name = "excluirUsuárioToolStripMenuItem";
            this.excluirUsuárioToolStripMenuItem.Text = "Excluir Usuário";
            this.excluirUsuárioToolStripMenuItem.Click += new System.EventHandler(this.excluirUsuárioToolStripMenuItem_Click);
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menu1ToolStripMenuItem.Text = "Ajuda";
            this.menu1ToolStripMenuItem.Click += new System.EventHandler(this.menu1ToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ajudaToolStripMenuItem.Text = "Exibir Ajuda";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBemVindo.ForeColor = System.Drawing.Color.White;
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(325, 74);
            this.lblBemVindo.TabIndex = 6;
            this.lblBemVindo.Text = "Bem Vindo!";
            // 
            // 
            // 
            // 
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(168, 58);
            this.btnEnviar.TabIndex = 32;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // lblIdArea
            // 
            this.lblIdArea.AutoSize = true;
            this.lblIdArea.BackColor = System.Drawing.Color.Transparent;
            this.lblIdArea.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblIdArea.ForeColor = System.Drawing.Color.White;
            this.lblIdArea.Name = "lblIdArea";
            this.lblIdArea.Size = new System.Drawing.Size(138, 35);
            this.lblIdArea.TabIndex = 26;
            this.lblIdArea.Text = "ID da Área:";
            this.lblIdArea.Visible = false;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(61, 35);
            this.lblCpf.TabIndex = 27;
            this.lblCpf.Text = "CPF:";
            this.lblCpf.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 35);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome:";
            this.lblNome.Visible = false;
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtIDArea
            // 
            this.txtIDArea.BackColor = System.Drawing.Color.White;
            this.txtIDArea.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtIDArea.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIDArea.Name = "txtIDArea";
            this.txtIDArea.Size = new System.Drawing.Size(316, 39);
            this.txtIDArea.TabIndex = 30;
            this.txtIDArea.Visible = false;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(393, 39);
            this.txtCpf.TabIndex = 29;
            this.txtCpf.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(364, 39);
            this.txtNome.TabIndex = 25;
            this.txtNome.Visible = false;
            // 
            // pnlModificarUser
            // 
            this.pnlModificarUser.Controls.Add(this.txtEmailMod);
            this.pnlModificarUser.Controls.Add(this.btnExcluir);
            this.pnlModificarUser.Controls.Add(this.btnMod);
            this.pnlModificarUser.Controls.Add(this.txtIdMod);
            this.pnlModificarUser.Controls.Add(this.lblIdMod);
            this.pnlModificarUser.Controls.Add(this.txtCpfMod);
            this.pnlModificarUser.Controls.Add(this.lblCpfMod);
            this.pnlModificarUser.Controls.Add(this.txtNomeMod);
            this.pnlModificarUser.Controls.Add(this.lblNomeMod);
            this.pnlModificarUser.Controls.Add(this.btnBuscar);
            this.pnlModificarUser.Controls.Add(this.lblEmailBusca);
            this.pnlModificarUser.Controls.Add(this.txtEmailBusca);
            this.pnlModificarUser.Controls.Add(this.btnBuscarExc);
            this.pnlModificarUser.Location = new System.Drawing.Point(2, 27);
            this.pnlModificarUser.Name = "pnlModificarUser";
            this.pnlModificarUser.Size = new System.Drawing.Size(596, 373);
            this.pnlModificarUser.TabIndex = 34;
            this.pnlModificarUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCriarUser_Paint);
            // 
            // txtEmailMod
            // 
            this.txtEmailMod.BackColor = System.Drawing.Color.White;
            this.txtEmailMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtEmailMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmailMod.Location = new System.Drawing.Point(125, 30);
            this.txtEmailMod.Name = "txtEmailMod";
            this.txtEmailMod.Size = new System.Drawing.Size(284, 39);
            this.txtEmailMod.TabIndex = 45;
            this.txtEmailMod.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(415, 287);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(169, 47);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.White;
            this.btnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMod.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMod.ForeColor = System.Drawing.Color.Black;
            this.btnMod.Location = new System.Drawing.Point(353, 287);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(231, 47);
            this.btnMod.TabIndex = 43;
            this.btnMod.Text = "Salvar Alterações";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Visible = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // txtIdMod
            // 
            this.txtIdMod.BackColor = System.Drawing.Color.White;
            this.txtIdMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtIdMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdMod.Location = new System.Drawing.Point(149, 217);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.Size = new System.Drawing.Size(340, 39);
            this.txtIdMod.TabIndex = 41;
            // 
            // lblIdMod
            // 
            this.lblIdMod.AutoSize = true;
            this.lblIdMod.BackColor = System.Drawing.Color.Transparent;
            this.lblIdMod.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblIdMod.ForeColor = System.Drawing.Color.White;
            this.lblIdMod.Location = new System.Drawing.Point(14, 217);
            this.lblIdMod.Name = "lblIdMod";
            this.lblIdMod.Size = new System.Drawing.Size(138, 35);
            this.lblIdMod.TabIndex = 42;
            this.lblIdMod.Text = "ID da Área:";
            // 
            // txtCpfMod
            // 
            this.txtCpfMod.BackColor = System.Drawing.Color.White;
            this.txtCpfMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtCpfMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCpfMod.Location = new System.Drawing.Point(100, 152);
            this.txtCpfMod.Name = "txtCpfMod";
            this.txtCpfMod.Size = new System.Drawing.Size(389, 39);
            this.txtCpfMod.TabIndex = 39;
            // 
            // lblCpfMod
            // 
            this.lblCpfMod.AutoSize = true;
            this.lblCpfMod.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfMod.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblCpfMod.ForeColor = System.Drawing.Color.White;
            this.lblCpfMod.Location = new System.Drawing.Point(14, 152);
            this.lblCpfMod.Name = "lblCpfMod";
            this.lblCpfMod.Size = new System.Drawing.Size(61, 35);
            this.lblCpfMod.TabIndex = 40;
            this.lblCpfMod.Text = "CPF:";
            // 
            // txtNomeMod
            // 
            this.txtNomeMod.BackColor = System.Drawing.Color.White;
            this.txtNomeMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtNomeMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeMod.Location = new System.Drawing.Point(100, 90);
            this.txtNomeMod.Name = "txtNomeMod";
            this.txtNomeMod.Size = new System.Drawing.Size(389, 39);
            this.txtNomeMod.TabIndex = 37;
            // 
            // lblNomeMod
            // 
            this.lblNomeMod.AutoSize = true;
            this.lblNomeMod.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeMod.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblNomeMod.ForeColor = System.Drawing.Color.White;
            this.lblNomeMod.Location = new System.Drawing.Point(14, 90);
            this.lblNomeMod.Name = "lblNomeMod";
            this.lblNomeMod.Size = new System.Drawing.Size(89, 35);
            this.lblNomeMod.TabIndex = 38;
            this.lblNomeMod.Text = "Nome:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(415, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(169, 47);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEmailBusca
            // 
            this.lblEmailBusca.AutoSize = true;
            this.lblEmailBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailBusca.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblEmailBusca.ForeColor = System.Drawing.Color.White;
            this.lblEmailBusca.Location = new System.Drawing.Point(14, 33);
            this.lblEmailBusca.Name = "lblEmailBusca";
            this.lblEmailBusca.Size = new System.Drawing.Size(105, 35);
            this.lblEmailBusca.TabIndex = 35;
            this.lblEmailBusca.Text = "Usuário:";
            // 
            // txtEmailBusca
            // 
            this.txtEmailBusca.BackColor = System.Drawing.Color.White;
            this.txtEmailBusca.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtEmailBusca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmailBusca.Location = new System.Drawing.Point(125, 31);
            this.txtEmailBusca.Name = "txtEmailBusca";
            this.txtEmailBusca.Size = new System.Drawing.Size(284, 39);
            this.txtEmailBusca.TabIndex = 34;
            // 
            // btnBuscarExc
            // 
            this.btnBuscarExc.BackColor = System.Drawing.Color.White;
            this.btnBuscarExc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarExc.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBuscarExc.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarExc.Location = new System.Drawing.Point(415, 25);
            this.btnBuscarExc.Name = "btnBuscarExc";
            this.btnBuscarExc.Size = new System.Drawing.Size(169, 47);
            this.btnBuscarExc.TabIndex = 46;
            this.btnBuscarExc.Text = "Buscar";
            this.btnBuscarExc.UseVisualStyleBackColor = false;
            this.btnBuscarExc.Visible = false;
            this.btnBuscarExc.Click += new System.EventHandler(this.btnBuscarExc_Click);
            // 
            // pnlCriarProd
            // 
            this.pnlCriarProd.Controls.Add(this.txtIdProdMod);
            this.pnlCriarProd.Controls.Add(this.btnBuscarProd);
            this.pnlCriarProd.Controls.Add(this.btnExcluirProd);
            this.pnlCriarProd.Controls.Add(this.btnModProd);
            this.pnlCriarProd.Controls.Add(this.txtPrecoProd);
            this.pnlCriarProd.Controls.Add(this.lblPrecoProd);
            this.pnlCriarProd.Controls.Add(this.txtMarcaProd);
            this.pnlCriarProd.Controls.Add(this.lblMarcaProd);
            this.pnlCriarProd.Controls.Add(this.txtNomeProd);
            this.pnlCriarProd.Controls.Add(this.lblNomeProd);
            this.pnlCriarProd.Controls.Add(this.btnSalvarProd);
            this.pnlCriarProd.Controls.Add(this.lblIdProd);
            this.pnlCriarProd.Controls.Add(this.txtIdProd);
            this.pnlCriarProd.Location = new System.Drawing.Point(1, 27);
            this.pnlCriarProd.Name = "pnlCriarProd";
            this.pnlCriarProd.Size = new System.Drawing.Size(597, 373);
            this.pnlCriarProd.TabIndex = 35;
            // 
            // txtIdProdMod
            // 
            this.txtIdProdMod.BackColor = System.Drawing.Color.White;
            this.txtIdProdMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtIdProdMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdProdMod.Location = new System.Drawing.Point(201, 25);
            this.txtIdProdMod.Name = "txtIdProdMod";
            this.txtIdProdMod.Size = new System.Drawing.Size(325, 39);
            this.txtIdProdMod.TabIndex = 59;
            this.txtIdProdMod.Visible = false;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.White;
            this.btnBuscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBuscarProd.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProd.Location = new System.Drawing.Point(242, 264);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(169, 47);
            this.btnBuscarProd.TabIndex = 58;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Visible = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.BackColor = System.Drawing.Color.White;
            this.btnExcluirProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProd.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExcluirProd.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirProd.Location = new System.Drawing.Point(180, 316);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(169, 47);
            this.btnExcluirProd.TabIndex = 57;
            this.btnExcluirProd.Text = "Excluir";
            this.btnExcluirProd.UseVisualStyleBackColor = false;
            this.btnExcluirProd.Visible = false;
            this.btnExcluirProd.Click += new System.EventHandler(this.btnExcluirProd_Click);
            // 
            // btnModProd
            // 
            this.btnModProd.BackColor = System.Drawing.Color.White;
            this.btnModProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModProd.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnModProd.ForeColor = System.Drawing.Color.Black;
            this.btnModProd.Location = new System.Drawing.Point(355, 316);
            this.btnModProd.Name = "btnModProd";
            this.btnModProd.Size = new System.Drawing.Size(231, 47);
            this.btnModProd.TabIndex = 56;
            this.btnModProd.Text = "Salvar Alterações";
            this.btnModProd.UseVisualStyleBackColor = false;
            this.btnModProd.Visible = false;
            this.btnModProd.Click += new System.EventHandler(this.btnAlteracoesProd_Click);
            // 
            // txtPrecoProd
            // 
            this.txtPrecoProd.BackColor = System.Drawing.Color.White;
            this.txtPrecoProd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtPrecoProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecoProd.Location = new System.Drawing.Point(111, 213);
            this.txtPrecoProd.Name = "txtPrecoProd";
            this.txtPrecoProd.Size = new System.Drawing.Size(415, 39);
            this.txtPrecoProd.TabIndex = 54;
            this.txtPrecoProd.Visible = false;
            // 
            // lblPrecoProd
            // 
            this.lblPrecoProd.AutoSize = true;
            this.lblPrecoProd.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoProd.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblPrecoProd.ForeColor = System.Drawing.Color.White;
            this.lblPrecoProd.Location = new System.Drawing.Point(16, 213);
            this.lblPrecoProd.Name = "lblPrecoProd";
            this.lblPrecoProd.Size = new System.Drawing.Size(83, 35);
            this.lblPrecoProd.TabIndex = 55;
            this.lblPrecoProd.Text = "Preço:";
            this.lblPrecoProd.Visible = false;
            // 
            // txtMarcaProd
            // 
            this.txtMarcaProd.BackColor = System.Drawing.Color.White;
            this.txtMarcaProd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtMarcaProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMarcaProd.Location = new System.Drawing.Point(111, 148);
            this.txtMarcaProd.Name = "txtMarcaProd";
            this.txtMarcaProd.Size = new System.Drawing.Size(415, 39);
            this.txtMarcaProd.TabIndex = 52;
            this.txtMarcaProd.Visible = false;
            // 
            // lblMarcaProd
            // 
            this.lblMarcaProd.AutoSize = true;
            this.lblMarcaProd.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaProd.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblMarcaProd.ForeColor = System.Drawing.Color.White;
            this.lblMarcaProd.Location = new System.Drawing.Point(16, 148);
            this.lblMarcaProd.Name = "lblMarcaProd";
            this.lblMarcaProd.Size = new System.Drawing.Size(89, 35);
            this.lblMarcaProd.TabIndex = 53;
            this.lblMarcaProd.Text = "Marca:";
            this.lblMarcaProd.Visible = false;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.BackColor = System.Drawing.Color.White;
            this.txtNomeProd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtNomeProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeProd.Location = new System.Drawing.Point(111, 86);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(415, 39);
            this.txtNomeProd.TabIndex = 50;
            this.txtNomeProd.Visible = false;
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProd.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblNomeProd.ForeColor = System.Drawing.Color.White;
            this.lblNomeProd.Location = new System.Drawing.Point(16, 86);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(89, 35);
            this.lblNomeProd.TabIndex = 51;
            this.lblNomeProd.Text = "Nome:";
            this.lblNomeProd.Visible = false;
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.BackColor = System.Drawing.Color.White;
            this.btnSalvarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSalvarProd.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarProd.Location = new System.Drawing.Point(417, 264);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(169, 47);
            this.btnSalvarProd.TabIndex = 49;
            this.btnSalvarProd.Text = "Salvar";
            this.btnSalvarProd.UseVisualStyleBackColor = false;
            this.btnSalvarProd.Visible = false;
            this.btnSalvarProd.Click += new System.EventHandler(this.btnSalvarProd_Click);
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.BackColor = System.Drawing.Color.Transparent;
            this.lblIdProd.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblIdProd.ForeColor = System.Drawing.Color.White;
            this.lblIdProd.Location = new System.Drawing.Point(16, 29);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(179, 35);
            this.lblIdProd.TabIndex = 48;
            this.lblIdProd.Text = "ID do Produto:";
            this.lblIdProd.Visible = false;
            // 
            // txtIdProd
            // 
            this.txtIdProd.BackColor = System.Drawing.Color.White;
            this.txtIdProd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtIdProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdProd.Location = new System.Drawing.Point(201, 25);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(325, 39);
            this.txtIdProd.TabIndex = 47;
            this.txtIdProd.Visible = false;
            // 
            // pnlCriarUser
            // 
            this.pnlCriarUser.Controls.Add(this.lblEmail);
            this.pnlCriarUser.Controls.Add(this.txtEmail);
            this.pnlCriarUser.Controls.Add(this.btnEnviar);
            this.pnlCriarUser.Controls.Add(this.lblIdArea);
            this.pnlCriarUser.Controls.Add(this.lblCpf);
            this.pnlCriarUser.Controls.Add(this.lblNome);
            this.pnlCriarUser.Controls.Add(this.txtIDArea);
            this.pnlCriarUser.Controls.Add(this.txtCpf);
            this.pnlCriarUser.Controls.Add(this.txtNome);
            this.pnlCriarUser.Location = new System.Drawing.Point(1, 27);
            this.pnlCriarUser.Name = "pnlCriarUser";
            this.pnlCriarUser.Size = new System.Drawing.Size(597, 373);
            this.pnlCriarUser.TabIndex = 34;
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(71)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(598, 402);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblIdArea);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtIDArea);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pnlCriarProd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlCriarUser);
            this.Controls.Add(this.pnlModificarUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlModificarUser.ResumeLayout(false);
            this.pnlModificarUser.PerformLayout();
            this.pnlCriarProd.ResumeLayout(false);
            this.pnlCriarProd.PerformLayout();
            this.pnlCriarUser.ResumeLayout(false);
            this.pnlCriarUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblIdArea;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIDArea;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel pnlModificarUser;
        private System.Windows.Forms.Panel pnlCriarUser;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEmailBusca;
        private System.Windows.Forms.TextBox txtEmailBusca;
        private System.Windows.Forms.Label lblNomeMod;
        private System.Windows.Forms.TextBox txtNomeMod;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox txtIdMod;
        private System.Windows.Forms.Label lblIdMod;
        private System.Windows.Forms.TextBox txtCpfMod;
        private System.Windows.Forms.Label lblCpfMod;
        private System.Windows.Forms.TextBox txtEmailMod;
        private System.Windows.Forms.Button btnBuscarExc;
        private System.Windows.Forms.ToolStripMenuItem menuProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirProdutosToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.Button btnModProd;
        private System.Windows.Forms.TextBox txtPrecoProd;
        private System.Windows.Forms.Label lblPrecoProd;
        private System.Windows.Forms.TextBox txtMarcaProd;
        private System.Windows.Forms.Label lblMarcaProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Button btnSalvarProd;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Panel pnlCriarProd;
        private System.Windows.Forms.TextBox txtIdProdMod;
        private Control txtEmail;
        private Control lblEmail;
    }
}

=======
﻿namespace SistemaDesktop
{
    partial class TelaMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
<<<<<<< HEAD
            this.menuProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemVindo = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
=======
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblIdArea = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtIDArea = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
<<<<<<< HEAD
            this.pnlModificarUser = new System.Windows.Forms.Panel();
            this.txtEmailMod = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            this.lblIdMod = new System.Windows.Forms.Label();
            this.txtCpfMod = new System.Windows.Forms.TextBox();
            this.lblCpfMod = new System.Windows.Forms.Label();
            this.txtNomeMod = new System.Windows.Forms.TextBox();
            this.lblNomeMod = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEmailBusca = new System.Windows.Forms.Label();
            this.txtEmailBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarExc = new System.Windows.Forms.Button();
            this.pnlCriarProd = new System.Windows.Forms.Panel();
            this.txtIdProdMod = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.btnModProd = new System.Windows.Forms.Button();
            this.txtPrecoProd = new System.Windows.Forms.TextBox();
            this.lblPrecoProd = new System.Windows.Forms.Label();
            this.txtMarcaProd = new System.Windows.Forms.TextBox();
            this.lblMarcaProd = new System.Windows.Forms.Label();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.btnSalvarProd = new System.Windows.Forms.Button();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.pnlCriarUser = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlModificarUser.SuspendLayout();
            this.pnlCriarProd.SuspendLayout();
            this.pnlCriarUser.SuspendLayout();
=======
            this.menuStrip1.SuspendLayout();
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
<<<<<<< HEAD
            this.menuProdutosToolStripMenuItem,
=======
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.menuToolStripMenuItem,
            this.menu1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
<<<<<<< HEAD
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuProdutosToolStripMenuItem
            // 
            this.menuProdutosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarProdutosToolStripMenuItem,
            this.modificarProdutosToolStripMenuItem,
            this.excluirProdutosToolStripMenuItem});
            this.menuProdutosToolStripMenuItem.Name = "menuProdutosToolStripMenuItem";
            this.menuProdutosToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.menuProdutosToolStripMenuItem.Text = "Menu Produtos";
            // 
            // criarProdutosToolStripMenuItem
            // 
            this.criarProdutosToolStripMenuItem.Name = "criarProdutosToolStripMenuItem";
            this.criarProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.criarProdutosToolStripMenuItem.Text = "Criar Produtos";
            this.criarProdutosToolStripMenuItem.Click += new System.EventHandler(this.criarProdutosToolStripMenuItem_Click);
            // 
            // modificarProdutosToolStripMenuItem
            // 
            this.modificarProdutosToolStripMenuItem.Name = "modificarProdutosToolStripMenuItem";
            this.modificarProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.modificarProdutosToolStripMenuItem.Text = "Modificar Produtos";
            this.modificarProdutosToolStripMenuItem.Click += new System.EventHandler(this.modificarProdutosToolStripMenuItem_Click);
            // 
            // excluirProdutosToolStripMenuItem
            // 
            this.excluirProdutosToolStripMenuItem.Name = "excluirProdutosToolStripMenuItem";
            this.excluirProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.excluirProdutosToolStripMenuItem.Text = "Excluir Produtos";
            this.excluirProdutosToolStripMenuItem.Click += new System.EventHandler(this.excluirProdutosToolStripMenuItem_Click);
=======
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarUsuárioToolStripMenuItem,
            this.modificarUsuárioToolStripMenuItem,
            this.excluirUsuárioToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
<<<<<<< HEAD
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.menuToolStripMenuItem.Text = "Menu Usuário";
=======
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Menu ";
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            // 
            // criarUsuárioToolStripMenuItem
            // 
            this.criarUsuárioToolStripMenuItem.Name = "criarUsuárioToolStripMenuItem";
<<<<<<< HEAD
            this.criarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
=======
            this.criarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.criarUsuárioToolStripMenuItem.Text = "Criar Usuário";
            this.criarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.criarUsuárioToolStripMenuItem_Click);
            // 
            // modificarUsuárioToolStripMenuItem
            // 
            this.modificarUsuárioToolStripMenuItem.Name = "modificarUsuárioToolStripMenuItem";
<<<<<<< HEAD
            this.modificarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.modificarUsuárioToolStripMenuItem.Text = "Modificar Usuário";
            this.modificarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuárioToolStripMenuItem_Click);
=======
            this.modificarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarUsuárioToolStripMenuItem.Text = "Modificar Usuário";
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            // 
            // excluirUsuárioToolStripMenuItem
            // 
            this.excluirUsuárioToolStripMenuItem.Name = "excluirUsuárioToolStripMenuItem";
<<<<<<< HEAD
            this.excluirUsuárioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.excluirUsuárioToolStripMenuItem.Text = "Excluir Usuário";
            this.excluirUsuárioToolStripMenuItem.Click += new System.EventHandler(this.excluirUsuárioToolStripMenuItem_Click);
=======
            this.excluirUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirUsuárioToolStripMenuItem.Text = "Excluir Usuário";
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menu1ToolStripMenuItem.Text = "Ajuda";
            this.menu1ToolStripMenuItem.Click += new System.EventHandler(this.menu1ToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ajudaToolStripMenuItem.Text = "Exibir Ajuda";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBemVindo.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.lblBemVindo.Location = new System.Drawing.Point(261, 39);
=======
            this.lblBemVindo.Location = new System.Drawing.Point(261, 35);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(325, 74);
            this.lblBemVindo.TabIndex = 6;
            this.lblBemVindo.Text = "Bem Vindo!";
            // 
<<<<<<< HEAD
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(30, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 35);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Usuário:";
            this.lblEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(150, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 39);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.Visible = false;
=======
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(32, 248);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 35);
            this.lblUsuario.TabIndex = 33;
            this.lblUsuario.Text = "Email:";
            this.lblUsuario.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(152, 245);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(340, 39);
            this.txtUsuario.TabIndex = 31;
            this.txtUsuario.Visible = false;
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.btnEnviar.Location = new System.Drawing.Point(393, 288);
=======
            this.btnEnviar.Location = new System.Drawing.Point(395, 314);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(168, 58);
            this.btnEnviar.TabIndex = 32;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // lblIdArea
            // 
            this.lblIdArea.AutoSize = true;
            this.lblIdArea.BackColor = System.Drawing.Color.Transparent;
            this.lblIdArea.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblIdArea.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.lblIdArea.Location = new System.Drawing.Point(30, 157);
=======
            this.lblIdArea.Location = new System.Drawing.Point(32, 183);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.lblIdArea.Name = "lblIdArea";
            this.lblIdArea.Size = new System.Drawing.Size(138, 35);
            this.lblIdArea.TabIndex = 26;
            this.lblIdArea.Text = "ID da Área:";
            this.lblIdArea.Visible = false;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblCpf.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.lblCpf.Location = new System.Drawing.Point(30, 98);
=======
            this.lblCpf.Location = new System.Drawing.Point(32, 124);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(61, 35);
            this.lblCpf.TabIndex = 27;
            this.lblCpf.Text = "CPF:";
            this.lblCpf.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblNome.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.lblNome.Location = new System.Drawing.Point(31, 35);
=======
            this.lblNome.Location = new System.Drawing.Point(33, 61);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 35);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome:";
            this.lblNome.Visible = false;
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtIDArea
            // 
            this.txtIDArea.BackColor = System.Drawing.Color.White;
            this.txtIDArea.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtIDArea.ForeColor = System.Drawing.SystemColors.WindowText;
<<<<<<< HEAD
            this.txtIDArea.Location = new System.Drawing.Point(174, 157);
=======
            this.txtIDArea.Location = new System.Drawing.Point(176, 183);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.txtIDArea.Name = "txtIDArea";
            this.txtIDArea.Size = new System.Drawing.Size(316, 39);
            this.txtIDArea.TabIndex = 30;
            this.txtIDArea.Visible = false;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 18F);
<<<<<<< HEAD
            this.txtCpf.Location = new System.Drawing.Point(97, 95);
=======
            this.txtCpf.Location = new System.Drawing.Point(99, 121);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(393, 39);
            this.txtCpf.TabIndex = 29;
            this.txtCpf.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 18F);
<<<<<<< HEAD
            this.txtNome.Location = new System.Drawing.Point(126, 35);
=======
            this.txtNome.Location = new System.Drawing.Point(128, 61);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(364, 39);
            this.txtNome.TabIndex = 25;
            this.txtNome.Visible = false;
            // 
<<<<<<< HEAD
            // pnlModificarUser
            // 
            this.pnlModificarUser.Controls.Add(this.txtEmailMod);
            this.pnlModificarUser.Controls.Add(this.btnExcluir);
            this.pnlModificarUser.Controls.Add(this.btnMod);
            this.pnlModificarUser.Controls.Add(this.txtIdMod);
            this.pnlModificarUser.Controls.Add(this.lblIdMod);
            this.pnlModificarUser.Controls.Add(this.txtCpfMod);
            this.pnlModificarUser.Controls.Add(this.lblCpfMod);
            this.pnlModificarUser.Controls.Add(this.txtNomeMod);
            this.pnlModificarUser.Controls.Add(this.lblNomeMod);
            this.pnlModificarUser.Controls.Add(this.btnBuscar);
            this.pnlModificarUser.Controls.Add(this.lblEmailBusca);
            this.pnlModificarUser.Controls.Add(this.txtEmailBusca);
            this.pnlModificarUser.Controls.Add(this.btnBuscarExc);
            this.pnlModificarUser.Location = new System.Drawing.Point(2, 27);
            this.pnlModificarUser.Name = "pnlModificarUser";
            this.pnlModificarUser.Size = new System.Drawing.Size(596, 373);
            this.pnlModificarUser.TabIndex = 34;
            this.pnlModificarUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCriarUser_Paint);
            // 
            // txtEmailMod
            // 
            this.txtEmailMod.BackColor = System.Drawing.Color.White;
            this.txtEmailMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtEmailMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmailMod.Location = new System.Drawing.Point(125, 30);
            this.txtEmailMod.Name = "txtEmailMod";
            this.txtEmailMod.Size = new System.Drawing.Size(284, 39);
            this.txtEmailMod.TabIndex = 45;
            this.txtEmailMod.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(415, 287);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(169, 47);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.White;
            this.btnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMod.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMod.ForeColor = System.Drawing.Color.Black;
            this.btnMod.Location = new System.Drawing.Point(353, 287);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(231, 47);
            this.btnMod.TabIndex = 43;
            this.btnMod.Text = "Salvar Alterações";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Visible = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // txtIdMod
            // 
            this.txtIdMod.BackColor = System.Drawing.Color.White;
            this.txtIdMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtIdMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdMod.Location = new System.Drawing.Point(149, 217);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.Size = new System.Drawing.Size(340, 39);
            this.txtIdMod.TabIndex = 41;
            // 
            // lblIdMod
            // 
            this.lblIdMod.AutoSize = true;
            this.lblIdMod.BackColor = System.Drawing.Color.Transparent;
            this.lblIdMod.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblIdMod.ForeColor = System.Drawing.Color.White;
            this.lblIdMod.Location = new System.Drawing.Point(14, 217);
            this.lblIdMod.Name = "lblIdMod";
            this.lblIdMod.Size = new System.Drawing.Size(138, 35);
            this.lblIdMod.TabIndex = 42;
            this.lblIdMod.Text = "ID da Área:";
            // 
            // txtCpfMod
            // 
            this.txtCpfMod.BackColor = System.Drawing.Color.White;
            this.txtCpfMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtCpfMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCpfMod.Location = new System.Drawing.Point(100, 152);
            this.txtCpfMod.Name = "txtCpfMod";
            this.txtCpfMod.Size = new System.Drawing.Size(389, 39);
            this.txtCpfMod.TabIndex = 39;
            // 
            // lblCpfMod
            // 
            this.lblCpfMod.AutoSize = true;
            this.lblCpfMod.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfMod.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblCpfMod.ForeColor = System.Drawing.Color.White;
            this.lblCpfMod.Location = new System.Drawing.Point(14, 152);
            this.lblCpfMod.Name = "lblCpfMod";
            this.lblCpfMod.Size = new System.Drawing.Size(61, 35);
            this.lblCpfMod.TabIndex = 40;
            this.lblCpfMod.Text = "CPF:";
            // 
            // txtNomeMod
            // 
            this.txtNomeMod.BackColor = System.Drawing.Color.White;
            this.txtNomeMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtNomeMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeMod.Location = new System.Drawing.Point(100, 90);
            this.txtNomeMod.Name = "txtNomeMod";
            this.txtNomeMod.Size = new System.Drawing.Size(389, 39);
            this.txtNomeMod.TabIndex = 37;
            // 
            // lblNomeMod
            // 
            this.lblNomeMod.AutoSize = true;
            this.lblNomeMod.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeMod.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblNomeMod.ForeColor = System.Drawing.Color.White;
            this.lblNomeMod.Location = new System.Drawing.Point(14, 90);
            this.lblNomeMod.Name = "lblNomeMod";
            this.lblNomeMod.Size = new System.Drawing.Size(89, 35);
            this.lblNomeMod.TabIndex = 38;
            this.lblNomeMod.Text = "Nome:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(415, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(169, 47);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEmailBusca
            // 
            this.lblEmailBusca.AutoSize = true;
            this.lblEmailBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailBusca.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblEmailBusca.ForeColor = System.Drawing.Color.White;
            this.lblEmailBusca.Location = new System.Drawing.Point(14, 33);
            this.lblEmailBusca.Name = "lblEmailBusca";
            this.lblEmailBusca.Size = new System.Drawing.Size(105, 35);
            this.lblEmailBusca.TabIndex = 35;
            this.lblEmailBusca.Text = "Usuário:";
            // 
            // txtEmailBusca
            // 
            this.txtEmailBusca.BackColor = System.Drawing.Color.White;
            this.txtEmailBusca.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtEmailBusca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmailBusca.Location = new System.Drawing.Point(125, 31);
            this.txtEmailBusca.Name = "txtEmailBusca";
            this.txtEmailBusca.Size = new System.Drawing.Size(284, 39);
            this.txtEmailBusca.TabIndex = 34;
            // 
            // btnBuscarExc
            // 
            this.btnBuscarExc.BackColor = System.Drawing.Color.White;
            this.btnBuscarExc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarExc.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBuscarExc.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarExc.Location = new System.Drawing.Point(415, 25);
            this.btnBuscarExc.Name = "btnBuscarExc";
            this.btnBuscarExc.Size = new System.Drawing.Size(169, 47);
            this.btnBuscarExc.TabIndex = 46;
            this.btnBuscarExc.Text = "Buscar";
            this.btnBuscarExc.UseVisualStyleBackColor = false;
            this.btnBuscarExc.Visible = false;
            this.btnBuscarExc.Click += new System.EventHandler(this.btnBuscarExc_Click);
            // 
            // pnlCriarProd
            // 
            this.pnlCriarProd.Controls.Add(this.txtIdProdMod);
            this.pnlCriarProd.Controls.Add(this.btnBuscarProd);
            this.pnlCriarProd.Controls.Add(this.btnExcluirProd);
            this.pnlCriarProd.Controls.Add(this.btnModProd);
            this.pnlCriarProd.Controls.Add(this.txtPrecoProd);
            this.pnlCriarProd.Controls.Add(this.lblPrecoProd);
            this.pnlCriarProd.Controls.Add(this.txtMarcaProd);
            this.pnlCriarProd.Controls.Add(this.lblMarcaProd);
            this.pnlCriarProd.Controls.Add(this.txtNomeProd);
            this.pnlCriarProd.Controls.Add(this.lblNomeProd);
            this.pnlCriarProd.Controls.Add(this.btnSalvarProd);
            this.pnlCriarProd.Controls.Add(this.lblIdProd);
            this.pnlCriarProd.Controls.Add(this.txtIdProd);
            this.pnlCriarProd.Location = new System.Drawing.Point(1, 27);
            this.pnlCriarProd.Name = "pnlCriarProd";
            this.pnlCriarProd.Size = new System.Drawing.Size(597, 373);
            this.pnlCriarProd.TabIndex = 35;
            // 
            // txtIdProdMod
            // 
            this.txtIdProdMod.BackColor = System.Drawing.Color.White;
            this.txtIdProdMod.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtIdProdMod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdProdMod.Location = new System.Drawing.Point(201, 25);
            this.txtIdProdMod.Name = "txtIdProdMod";
            this.txtIdProdMod.Size = new System.Drawing.Size(325, 39);
            this.txtIdProdMod.TabIndex = 59;
            this.txtIdProdMod.Visible = false;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.White;
            this.btnBuscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBuscarProd.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProd.Location = new System.Drawing.Point(242, 264);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(169, 47);
            this.btnBuscarProd.TabIndex = 58;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Visible = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.BackColor = System.Drawing.Color.White;
            this.btnExcluirProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProd.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExcluirProd.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirProd.Location = new System.Drawing.Point(180, 316);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(169, 47);
            this.btnExcluirProd.TabIndex = 57;
            this.btnExcluirProd.Text = "Excluir";
            this.btnExcluirProd.UseVisualStyleBackColor = false;
            this.btnExcluirProd.Visible = false;
            this.btnExcluirProd.Click += new System.EventHandler(this.btnExcluirProd_Click);
            // 
            // btnModProd
            // 
            this.btnModProd.BackColor = System.Drawing.Color.White;
            this.btnModProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModProd.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnModProd.ForeColor = System.Drawing.Color.Black;
            this.btnModProd.Location = new System.Drawing.Point(355, 316);
            this.btnModProd.Name = "btnModProd";
            this.btnModProd.Size = new System.Drawing.Size(231, 47);
            this.btnModProd.TabIndex = 56;
            this.btnModProd.Text = "Salvar Alterações";
            this.btnModProd.UseVisualStyleBackColor = false;
            this.btnModProd.Visible = false;
            this.btnModProd.Click += new System.EventHandler(this.btnAlteracoesProd_Click);
            // 
            // txtPrecoProd
            // 
            this.txtPrecoProd.BackColor = System.Drawing.Color.White;
            this.txtPrecoProd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtPrecoProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecoProd.Location = new System.Drawing.Point(111, 213);
            this.txtPrecoProd.Name = "txtPrecoProd";
            this.txtPrecoProd.Size = new System.Drawing.Size(415, 39);
            this.txtPrecoProd.TabIndex = 54;
            this.txtPrecoProd.Visible = false;
            // 
            // lblPrecoProd
            // 
            this.lblPrecoProd.AutoSize = true;
            this.lblPrecoProd.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoProd.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblPrecoProd.ForeColor = System.Drawing.Color.White;
            this.lblPrecoProd.Location = new System.Drawing.Point(16, 213);
            this.lblPrecoProd.Name = "lblPrecoProd";
            this.lblPrecoProd.Size = new System.Drawing.Size(83, 35);
            this.lblPrecoProd.TabIndex = 55;
            this.lblPrecoProd.Text = "Preço:";
            this.lblPrecoProd.Visible = false;
            // 
            // txtMarcaProd
            // 
            this.txtMarcaProd.BackColor = System.Drawing.Color.White;
            this.txtMarcaProd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtMarcaProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMarcaProd.Location = new System.Drawing.Point(111, 148);
            this.txtMarcaProd.Name = "txtMarcaProd";
            this.txtMarcaProd.Size = new System.Drawing.Size(415, 39);
            this.txtMarcaProd.TabIndex = 52;
            this.txtMarcaProd.Visible = false;
            // 
            // lblMarcaProd
            // 
            this.lblMarcaProd.AutoSize = true;
            this.lblMarcaProd.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaProd.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblMarcaProd.ForeColor = System.Drawing.Color.White;
            this.lblMarcaProd.Location = new System.Drawing.Point(16, 148);
            this.lblMarcaProd.Name = "lblMarcaProd";
            this.lblMarcaProd.Size = new System.Drawing.Size(89, 35);
            this.lblMarcaProd.TabIndex = 53;
            this.lblMarcaProd.Text = "Marca:";
            this.lblMarcaProd.Visible = false;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.BackColor = System.Drawing.Color.White;
            this.txtNomeProd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtNomeProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeProd.Location = new System.Drawing.Point(111, 86);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(415, 39);
            this.txtNomeProd.TabIndex = 50;
            this.txtNomeProd.Visible = false;
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProd.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblNomeProd.ForeColor = System.Drawing.Color.White;
            this.lblNomeProd.Location = new System.Drawing.Point(16, 86);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(89, 35);
            this.lblNomeProd.TabIndex = 51;
            this.lblNomeProd.Text = "Nome:";
            this.lblNomeProd.Visible = false;
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.BackColor = System.Drawing.Color.White;
            this.btnSalvarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarProd.Font = new System.Drawing.Font("Segoe UI Semibold", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSalvarProd.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarProd.Location = new System.Drawing.Point(417, 264);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(169, 47);
            this.btnSalvarProd.TabIndex = 49;
            this.btnSalvarProd.Text = "Salvar";
            this.btnSalvarProd.UseVisualStyleBackColor = false;
            this.btnSalvarProd.Visible = false;
            this.btnSalvarProd.Click += new System.EventHandler(this.btnSalvarProd_Click);
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.BackColor = System.Drawing.Color.Transparent;
            this.lblIdProd.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.lblIdProd.ForeColor = System.Drawing.Color.White;
            this.lblIdProd.Location = new System.Drawing.Point(16, 29);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(179, 35);
            this.lblIdProd.TabIndex = 48;
            this.lblIdProd.Text = "ID do Produto:";
            this.lblIdProd.Visible = false;
            // 
            // txtIdProd
            // 
            this.txtIdProd.BackColor = System.Drawing.Color.White;
            this.txtIdProd.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtIdProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdProd.Location = new System.Drawing.Point(201, 25);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(325, 39);
            this.txtIdProd.TabIndex = 47;
            this.txtIdProd.Visible = false;
            // 
            // pnlCriarUser
            // 
            this.pnlCriarUser.Controls.Add(this.lblEmail);
            this.pnlCriarUser.Controls.Add(this.txtEmail);
            this.pnlCriarUser.Controls.Add(this.btnEnviar);
            this.pnlCriarUser.Controls.Add(this.lblIdArea);
            this.pnlCriarUser.Controls.Add(this.lblCpf);
            this.pnlCriarUser.Controls.Add(this.lblNome);
            this.pnlCriarUser.Controls.Add(this.txtIDArea);
            this.pnlCriarUser.Controls.Add(this.txtCpf);
            this.pnlCriarUser.Controls.Add(this.txtNome);
            this.pnlCriarUser.Location = new System.Drawing.Point(1, 27);
            this.pnlCriarUser.Name = "pnlCriarUser";
            this.pnlCriarUser.Size = new System.Drawing.Size(597, 373);
            this.pnlCriarUser.TabIndex = 34;
            // 
=======
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(71)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(598, 402);
<<<<<<< HEAD
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pnlCriarProd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlCriarUser);
            this.Controls.Add(this.pnlModificarUser);
=======
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblIdArea);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtIDArea);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.menuStrip1);
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
<<<<<<< HEAD
            this.pnlModificarUser.ResumeLayout(false);
            this.pnlModificarUser.PerformLayout();
            this.pnlCriarProd.ResumeLayout(false);
            this.pnlCriarProd.PerformLayout();
            this.pnlCriarUser.ResumeLayout(false);
            this.pnlCriarUser.PerformLayout();
=======
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Label lblBemVindo;
<<<<<<< HEAD
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
=======
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblIdArea;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIDArea;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
<<<<<<< HEAD
        private System.Windows.Forms.Panel pnlModificarUser;
        private System.Windows.Forms.Panel pnlCriarUser;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEmailBusca;
        private System.Windows.Forms.TextBox txtEmailBusca;
        private System.Windows.Forms.Label lblNomeMod;
        private System.Windows.Forms.TextBox txtNomeMod;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox txtIdMod;
        private System.Windows.Forms.Label lblIdMod;
        private System.Windows.Forms.TextBox txtCpfMod;
        private System.Windows.Forms.Label lblCpfMod;
        private System.Windows.Forms.TextBox txtEmailMod;
        private System.Windows.Forms.Button btnBuscarExc;
        private System.Windows.Forms.ToolStripMenuItem menuProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirProdutosToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.Button btnModProd;
        private System.Windows.Forms.TextBox txtPrecoProd;
        private System.Windows.Forms.Label lblPrecoProd;
        private System.Windows.Forms.TextBox txtMarcaProd;
        private System.Windows.Forms.Label lblMarcaProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Button btnSalvarProd;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Panel pnlCriarProd;
        private System.Windows.Forms.TextBox txtIdProdMod;
=======
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8
    }
}

>>>>>>> ed96bf4d5d5f264d682401631813797a4595fcc9

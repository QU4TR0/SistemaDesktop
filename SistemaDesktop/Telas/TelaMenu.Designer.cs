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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblIdArea = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtIDArea = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menu1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarUsuárioToolStripMenuItem,
            this.modificarUsuárioToolStripMenuItem,
            this.excluirUsuárioToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Menu ";
            // 
            // criarUsuárioToolStripMenuItem
            // 
            this.criarUsuárioToolStripMenuItem.Name = "criarUsuárioToolStripMenuItem";
            this.criarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarUsuárioToolStripMenuItem.Text = "Criar Usuário";
            this.criarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.criarUsuárioToolStripMenuItem_Click);
            // 
            // modificarUsuárioToolStripMenuItem
            // 
            this.modificarUsuárioToolStripMenuItem.Name = "modificarUsuárioToolStripMenuItem";
            this.modificarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarUsuárioToolStripMenuItem.Text = "Modificar Usuário";
            // 
            // excluirUsuárioToolStripMenuItem
            // 
            this.excluirUsuárioToolStripMenuItem.Name = "excluirUsuárioToolStripMenuItem";
            this.excluirUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirUsuárioToolStripMenuItem.Text = "Excluir Usuário";
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
            this.lblBemVindo.Location = new System.Drawing.Point(261, 35);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(325, 74);
            this.lblBemVindo.TabIndex = 6;
            this.lblBemVindo.Text = "Bem Vindo!";
            // 
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
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(395, 314);
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
            this.lblIdArea.Location = new System.Drawing.Point(32, 183);
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
            this.lblCpf.Location = new System.Drawing.Point(32, 124);
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
            this.lblNome.Location = new System.Drawing.Point(33, 61);
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
            this.txtIDArea.Location = new System.Drawing.Point(176, 183);
            this.txtIDArea.Name = "txtIDArea";
            this.txtIDArea.Size = new System.Drawing.Size(316, 39);
            this.txtIDArea.TabIndex = 30;
            this.txtIDArea.Visible = false;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtCpf.Location = new System.Drawing.Point(99, 121);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(393, 39);
            this.txtCpf.TabIndex = 29;
            this.txtCpf.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtNome.Location = new System.Drawing.Point(128, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(364, 39);
            this.txtNome.TabIndex = 25;
            this.txtNome.Visible = false;
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblIdArea;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIDArea;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
    }
}


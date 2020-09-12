namespace Notas
{
    partial class Home
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btn_arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_arquivo_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_arquivo_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_arquivo_abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_arquivo_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CT_principal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numero_de_caracteres = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvo = new System.Windows.Forms.Label();
            this.abrir_arquivo = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Gainsboro;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_arquivo,
            this.ajudaToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(743, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // btn_arquivo
            // 
            this.btn_arquivo.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btn_arquivo_novo,
            this.btn_arquivo_salvar,
            this.btn_arquivo_abrir,
            this.toolStripSeparator2,
            this.btn_arquivo_sair});
            this.btn_arquivo.Name = "btn_arquivo";
            this.btn_arquivo.Size = new System.Drawing.Size(61, 20);
            this.btn_arquivo.Text = "Arquivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // btn_arquivo_novo
            // 
            this.btn_arquivo_novo.BackColor = System.Drawing.Color.Transparent;
            this.btn_arquivo_novo.Name = "btn_arquivo_novo";
            this.btn_arquivo_novo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btn_arquivo_novo.Size = new System.Drawing.Size(180, 22);
            this.btn_arquivo_novo.Text = "Novo";
            this.btn_arquivo_novo.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // btn_arquivo_salvar
            // 
            this.btn_arquivo_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_arquivo_salvar.Name = "btn_arquivo_salvar";
            this.btn_arquivo_salvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btn_arquivo_salvar.Size = new System.Drawing.Size(180, 22);
            this.btn_arquivo_salvar.Text = "Salvar";
            this.btn_arquivo_salvar.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // btn_arquivo_abrir
            // 
            this.btn_arquivo_abrir.BackColor = System.Drawing.Color.Transparent;
            this.btn_arquivo_abrir.Name = "btn_arquivo_abrir";
            this.btn_arquivo_abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.btn_arquivo_abrir.Size = new System.Drawing.Size(180, 22);
            this.btn_arquivo_abrir.Text = "Abrir";
            this.btn_arquivo_abrir.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // btn_arquivo_sair
            // 
            this.btn_arquivo_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_arquivo_sair.Name = "btn_arquivo_sair";
            this.btn_arquivo_sair.Size = new System.Drawing.Size(180, 22);
            this.btn_arquivo_sair.Text = "Sair";
            this.btn_arquivo_sair.Click += new System.EventHandler(this.btn_arquivo_sair_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // CT_principal
            // 
            this.CT_principal.AcceptsReturn = true;
            this.CT_principal.AllowDrop = true;
            this.CT_principal.BackColor = System.Drawing.Color.White;
            this.CT_principal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CT_principal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CT_principal.ForeColor = System.Drawing.Color.Black;
            this.CT_principal.HideSelection = false;
            this.CT_principal.Location = new System.Drawing.Point(4, 27);
            this.CT_principal.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.CT_principal.MaximumSize = new System.Drawing.Size(736, 395);
            this.CT_principal.MinimumSize = new System.Drawing.Size(736, 395);
            this.CT_principal.Multiline = true;
            this.CT_principal.Name = "CT_principal";
            this.CT_principal.Size = new System.Drawing.Size(736, 395);
            this.CT_principal.TabIndex = 1;
            this.CT_principal.Text = "Digite aqui...";
            this.CT_principal.Visible = false;
            this.CT_principal.Click += new System.EventHandler(this.CT_principal_TextChanged);
            this.CT_principal.TextChanged += new System.EventHandler(this.CT_principal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(158, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de caracteres: ";
            // 
            // numero_de_caracteres
            // 
            this.numero_de_caracteres.AutoSize = true;
            this.numero_de_caracteres.BackColor = System.Drawing.Color.Gainsboro;
            this.numero_de_caracteres.ForeColor = System.Drawing.Color.Gray;
            this.numero_de_caracteres.Location = new System.Drawing.Point(285, 5);
            this.numero_de_caracteres.Name = "numero_de_caracteres";
            this.numero_de_caracteres.Size = new System.Drawing.Size(13, 15);
            this.numero_de_caracteres.TabIndex = 3;
            this.numero_de_caracteres.Text = "0";
            this.numero_de_caracteres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // salvo
            // 
            this.salvo.AutoSize = true;
            this.salvo.BackColor = System.Drawing.Color.Gainsboro;
            this.salvo.ForeColor = System.Drawing.Color.Red;
            this.salvo.Location = new System.Drawing.Point(615, 5);
            this.salvo.Name = "salvo";
            this.salvo.Size = new System.Drawing.Size(128, 15);
            this.salvo.TabIndex = 4;
            this.salvo.Text = "Alterações não salvas !!";
            this.salvo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abrir_arquivo
            // 
            this.abrir_arquivo.FileName = "nome arquivo";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 425);
            this.Controls.Add(this.salvo);
            this.Controls.Add(this.numero_de_caracteres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CT_principal);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Name = "Home";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btn_arquivo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btn_arquivo_abrir;
        private System.Windows.Forms.ToolStripMenuItem btn_arquivo_salvar;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_arquivo_novo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btn_arquivo_sair;
        private System.Windows.Forms.TextBox CT_principal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numero_de_caracteres;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label salvo;
        private System.Windows.Forms.OpenFileDialog abrir_arquivo;
    }
}


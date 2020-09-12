using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    
    public partial class Home : Form
    {
        string salvar_em = null;
        public Home()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Salvar pressionado");

            if (salvar_em == null)
                MessageBox.Show("Arquivo ainda não foi criado..");
            else
            {
                using (File.Create(salvar_em))
                {
                    
                }

                File.WriteAllText(salvar_em, CT_principal.Text);
                salvo.ForeColor = Color.Green;
                salvo.Text = "Alterações salvas";
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Abrir pressionado");
            abrir_arquivo.DefaultExt = ".txt";
            
            abrir_arquivo.ShowDialog();
            Console.WriteLine(abrir_arquivo.FileName);
            salvar_em = abrir_arquivo.FileName;
            abrir_arquivo.Dispose();

            CT_principal.Visible = true;
            CT_principal.Text = File.ReadAllText(salvar_em);

            
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Novo pressionado");

            FrmNovoArquivo novo_arquivo = new FrmNovoArquivo();
            novo_arquivo.ShowDialog();
            salvar_em = novo_arquivo.patch;
            CT_principal.Visible = true;
            
        }

        private void btn_arquivo_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void CT_principal_TextChanged(object sender, EventArgs e)
        {
            salvo.ForeColor = Color.Red;
            salvo.Text = "Alterações não salvas";
            numero_de_caracteres.Text = CT_principal.Text.Length.ToString();
        }

        private void btn_zoom_aumentar_Click(object sender, EventArgs e)
        {
           

        }

        private void CT_principal_MouseClick(object sender, MouseEventArgs e)
        {
            CT_principal.Text = "";
        }
    }
}

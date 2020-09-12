using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notas
{
    public partial class FrmNovoArquivo : Form
    {
        public bool editor_de_texto = false;
        public string patch = null;
        public FrmNovoArquivo()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            selecionar_pasta.Description = "Salvar em";
            selecionar_pasta.ShowDialog();
            patch = selecionar_pasta.SelectedPath + "\\" + CT_nome_arquivo.Text + ".txt";
            Console.WriteLine(patch);
            selecionar_pasta.Dispose();
            this.Close();

        }
    }
}

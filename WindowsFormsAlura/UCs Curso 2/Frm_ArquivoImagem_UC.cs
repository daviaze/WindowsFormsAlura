using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlura.UCs_Curso_2
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivoImagem;
            Pic_Arquivo.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();
            if (CDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = CDb.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new FontDialog();
            if (FDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = FDb.Font;
            }
        }
    }
}

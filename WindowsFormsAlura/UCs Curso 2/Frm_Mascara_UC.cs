using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlura
{
    public partial class Frm_Mascara_UC : UserControl
    {
        public Frm_Mascara_UC()
        {
            InitializeComponent();
        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Msk_TextBox.Mask = "00:00";
            Msk_TextBox.Text = "";
            Lbl_MascaraAtiva.Text = "00:00";
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Msk_TextBox.Mask = "00000-000";
            Msk_TextBox.Text = "";
            Lbl_MascaraAtiva.Text = "00000-000";
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Msk_TextBox.Mask = "$ 000,000,000.00";
            Msk_TextBox.Text = "";
            Lbl_MascaraAtiva.Text = "$ 000,000,000.00";
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Msk_TextBox.Mask = "00/00/0000";
            Msk_TextBox.Text = "";
            Lbl_MascaraAtiva.Text = "00/00/0000";
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = true;
            Msk_TextBox.Mask = "0000000";
            Msk_TextBox.Text = "";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Msk_TextBox.Mask = "(00) 00000-0000";
            Msk_TextBox.Text = "";
            Lbl_MascaraAtiva.Text = "(00) 00000-0000";
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            Lbl_Conteudo.Text = Msk_TextBox.Text;
        }
    }
}

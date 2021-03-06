using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAluraBiblioteca;

namespace WindowsFormsAlura
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool resultado = Cls_Utils.Valida(Msk_CPF.Text);
            if (Msk_CPF.Text.Replace(".", "").Replace("-", "").Trim() == "")
            {
                MessageBox.Show("CPF vazio, por favor preencha o campo CPF", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Msk_CPF.Text.Replace(".", "").Replace("-", "").Trim().Length != 11)
                {
                    MessageBox.Show("O CPF precisa conter 11 dígitos", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (resultado)
                    {
                        MessageBox.Show("CPF válido", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAlura.Dialogs;
using WindowsFormsAluraBiblioteca;

namespace WindowsFormsAlura
{
    public partial class Frm_ValidaCPF2_UC : UserControl
    {
        public Frm_ValidaCPF2_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
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
                    Frm_Questao fq = new Frm_Questao("Frm_ValidaCPF2", "Valida aí pô");
                    fq.ShowDialog();

                    if (fq.DialogResult == DialogResult.OK)
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
                    else
                    {

                    }
                }
            }
        }
    }
}

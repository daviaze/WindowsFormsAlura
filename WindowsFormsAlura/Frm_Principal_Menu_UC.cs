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
using WindowsFormsAlura.Formularios_Curso_2;
using WindowsFormsAlura.UCs_Curso_2;

namespace WindowsFormsAlura
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleSenhaForte = 0;
        int ControleArquivoImagem = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            fecharAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;

            Frm_Mascara_UC f = new Frm_Mascara_UC();
            f.Dock = DockStyle.Fill;

            TabPage t = new TabPage();
            t.Name = "Mascara " + ControleMascara;
            t.Text = "Mascara " + ControleMascara;
            t.ImageIndex = 2;
            t.Controls.Add(f);

            Tbc_Aplicacoes.TabPages.Add(t);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;

            Frm_ValidaCPF_UC f = new Frm_ValidaCPF_UC();
            f.Dock = DockStyle.Fill;

            TabPage t = new TabPage();
            t.Name = "Valida CPF " + ControleValidaCPF;
            t.Text = "Valida CPF " + ControleValidaCPF;
            t.ImageIndex = 3;
            t.Controls.Add(f);

            Tbc_Aplicacoes.TabPages.Add(t);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;

            Frm_ValidaCPF2_UC f = new Frm_ValidaCPF2_UC();
            f.Dock = DockStyle.Fill;

            TabPage t = new TabPage();
            t.Name = "Valida CPF2 " + ControleValidaCPF2;
            t.Text = "Valida CPF2 " + ControleValidaCPF2;
            t.ImageIndex = 4;
            t.Controls.Add(f);

            Tbc_Aplicacoes.TabPages.Add(t);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleSenhaForte += 1;

            Frm_ValidaSenhaForte_UC f = new Frm_ValidaSenhaForte_UC();
            f.Dock = DockStyle.Fill;

            TabPage t = new TabPage();
            t.Name = "Controle Senha Forte " + ControleSenhaForte;
            t.Text = "Controle Senha Forte " + ControleSenhaForte;
            t.ImageIndex = 5;
            t.Controls.Add(f);

            Tbc_Aplicacoes.TabPages.Add(t);
        }

        private void fecharAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\desenvolvimento\\CursoAlura\\WindowsFormsAlura\\WindowsFormsAlura\\Imagens";// o Open File irá sempre startar neste repositório
            Db.Filter = "PNG|*.PNG"; // Vai filtrar somente os arquivos com esta extensão
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName; // Pega o nome do arquivo que foi selecionado e clicado em OK em seguida

                ControleArquivoImagem += 1;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem); // Istancia o formulário a ser chamado
                U.Dock = DockStyle.Fill; // Para ocupar toda a tela do tabcontrol
                TabPage TB = new TabPage(); // Instancia a tabpage
                TB.Name = "Arquivo Imagem " + ControleArquivoImagem;
                TB.Text = "Arquivo Imagem " + ControleArquivoImagem;
                TB.ImageIndex = 6; // Coloque aqui o índice da imagem que representa uma pasta
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB); // Adiciona o tabpage ao tabcontrol
            }
        }

        private void Frm_Principal_Menu_UC_Load(object sender, EventArgs e)
        {

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {

                string senha = F.senha;
                string login = F.login;

                if (WindowsFormsAluraBiblioteca.Cls_Utils.ValidaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    fecharAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + login + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha inválida !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Db = new Frm_Questao("icons8_question_64", "Você deseja se desconectar ?");
            Db.ShowDialog();
            //if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            if (Db.DialogResult == DialogResult.OK)
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);

                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i += -1)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                fecharAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
            }
        }
    }
}

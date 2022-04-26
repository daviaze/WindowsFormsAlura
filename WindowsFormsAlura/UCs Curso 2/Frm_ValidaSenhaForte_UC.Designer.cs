
namespace WindowsFormsAlura.UCs_Curso_2
{
    partial class Frm_ValidaSenhaForte_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_VerSenha = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_VerSenha
            // 
            this.Btn_VerSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_VerSenha.Location = new System.Drawing.Point(329, 159);
            this.Btn_VerSenha.Name = "Btn_VerSenha";
            this.Btn_VerSenha.Size = new System.Drawing.Size(111, 23);
            this.Btn_VerSenha.TabIndex = 7;
            this.Btn_VerSenha.Text = "Mostrar Senha";
            this.Btn_VerSenha.UseVisualStyleBackColor = true;
            this.Btn_VerSenha.Click += new System.EventHandler(this.Btn_VerSenha_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Reset.Location = new System.Drawing.Point(329, 130);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(111, 23);
            this.Btn_Reset.TabIndex = 6;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Resultado.Location = new System.Drawing.Point(96, 178);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 22);
            this.Lbl_Resultado.TabIndex = 5;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Senha.Location = new System.Drawing.Point(96, 133);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(100, 23);
            this.Txt_Senha.TabIndex = 4;
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // Frm_ValidaSenhaForte_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_VerSenha);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Txt_Senha);
            this.Name = "Frm_ValidaSenhaForte_UC";
            this.Size = new System.Drawing.Size(537, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_VerSenha;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.TextBox Txt_Senha;
    }
}

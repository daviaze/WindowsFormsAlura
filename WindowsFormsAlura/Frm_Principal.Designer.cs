
namespace WindowsFormsAlura
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Btn_ValidaSenha = new System.Windows.Forms.Button();
            this.Btn_Mascara = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ValidaSenha
            // 
            this.Btn_ValidaSenha.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ValidaSenha.Image")));
            this.Btn_ValidaSenha.Location = new System.Drawing.Point(58, 12);
            this.Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            this.Btn_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaSenha.TabIndex = 0;
            this.Btn_ValidaSenha.Text = "Valida Senha";
            this.Btn_ValidaSenha.UseVisualStyleBackColor = true;
            this.Btn_ValidaSenha.Click += new System.EventHandler(this.Btn_ValidaSenha_Click);
            // 
            // Btn_Mascara
            // 
            this.Btn_Mascara.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Mascara.Image")));
            this.Btn_Mascara.Location = new System.Drawing.Point(201, 12);
            this.Btn_Mascara.Name = "Btn_Mascara";
            this.Btn_Mascara.Size = new System.Drawing.Size(114, 48);
            this.Btn_Mascara.TabIndex = 1;
            this.Btn_Mascara.Text = "Mascara";
            this.Btn_Mascara.UseVisualStyleBackColor = true;
            this.Btn_Mascara.Click += new System.EventHandler(this.Btn_Mascara_Click);
            // 
            // Btn_ValidaCPF
            // 
            this.Btn_ValidaCPF.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ValidaCPF.Image")));
            this.Btn_ValidaCPF.Location = new System.Drawing.Point(58, 66);
            this.Btn_ValidaCPF.Name = "Btn_ValidaCPF";
            this.Btn_ValidaCPF.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaCPF.TabIndex = 2;
            this.Btn_ValidaCPF.Text = "Valida CPF";
            this.Btn_ValidaCPF.UseVisualStyleBackColor = true;
            this.Btn_ValidaCPF.Click += new System.EventHandler(this.Btn_ValidaCPF_Click);
            // 
            // Btn_ValidaCPF2
            // 
            this.Btn_ValidaCPF2.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ValidaCPF2.Image")));
            this.Btn_ValidaCPF2.Location = new System.Drawing.Point(201, 66);
            this.Btn_ValidaCPF2.Name = "Btn_ValidaCPF2";
            this.Btn_ValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaCPF2.TabIndex = 3;
            this.Btn_ValidaCPF2.Text = "Valida CPF2";
            this.Btn_ValidaCPF2.UseVisualStyleBackColor = true;
            this.Btn_ValidaCPF2.Click += new System.EventHandler(this.Btn_ValidaCPF2_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.Btn_ValidaCPF2);
            this.Controls.Add(this.Btn_ValidaCPF);
            this.Controls.Add(this.Btn_Mascara);
            this.Controls.Add(this.Btn_ValidaSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ValidaSenha;
        private System.Windows.Forms.Button Btn_Mascara;
        private System.Windows.Forms.Button Btn_ValidaCPF;
        private System.Windows.Forms.Button Btn_ValidaCPF2;
    }
}
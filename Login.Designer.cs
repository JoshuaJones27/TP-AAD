namespace TP_AED
{
    partial class Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.txb_utilizador = new System.Windows.Forms.TextBox();
            this.lbl_utilizador = new System.Windows.Forms.Label();
            this.lbl_palavraPasse = new System.Windows.Forms.Label();
            this.txb_palavraPasse = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_registar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(15, 189);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Login_btn_click_Click);
            // 
            // txb_utilizador
            // 
            this.txb_utilizador.Location = new System.Drawing.Point(130, 6);
            this.txb_utilizador.Name = "txb_utilizador";
            this.txb_utilizador.Size = new System.Drawing.Size(253, 22);
            this.txb_utilizador.TabIndex = 1;
            // 
            // lbl_utilizador
            // 
            this.lbl_utilizador.AutoSize = true;
            this.lbl_utilizador.Location = new System.Drawing.Point(12, 9);
            this.lbl_utilizador.Name = "lbl_utilizador";
            this.lbl_utilizador.Size = new System.Drawing.Size(66, 16);
            this.lbl_utilizador.TabIndex = 2;
            this.lbl_utilizador.Text = "Utilizador:";
            // 
            // lbl_palavraPasse
            // 
            this.lbl_palavraPasse.AutoSize = true;
            this.lbl_palavraPasse.Location = new System.Drawing.Point(12, 64);
            this.lbl_palavraPasse.Name = "lbl_palavraPasse";
            this.lbl_palavraPasse.Size = new System.Drawing.Size(99, 16);
            this.lbl_palavraPasse.TabIndex = 4;
            this.lbl_palavraPasse.Text = "Palavra Passe:";
            // 
            // txb_palavraPasse
            // 
            this.txb_palavraPasse.Location = new System.Drawing.Point(130, 61);
            this.txb_palavraPasse.Name = "txb_palavraPasse";
            this.txb_palavraPasse.Size = new System.Drawing.Size(253, 22);
            this.txb_palavraPasse.TabIndex = 3;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(308, 189);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_registar
            // 
            this.btn_registar.Location = new System.Drawing.Point(161, 189);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(75, 23);
            this.btn_registar.TabIndex = 6;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseVisualStyleBackColor = true;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 222);
            this.Controls.Add(this.btn_registar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_palavraPasse);
            this.Controls.Add(this.txb_palavraPasse);
            this.Controls.Add(this.lbl_utilizador);
            this.Controls.Add(this.txb_utilizador);
            this.Controls.Add(this.btn_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txb_utilizador;
        private System.Windows.Forms.Label lbl_utilizador;
        private System.Windows.Forms.Label lbl_palavraPasse;
        private System.Windows.Forms.TextBox txb_palavraPasse;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_registar;
    }
}
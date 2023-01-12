namespace TP_AED
{
    partial class User
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
            this.btn_dados = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_idTipoUtilizador = new System.Windows.Forms.Label();
            this.lbl_dataNascimento = new System.Windows.Forms.Label();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.lbl_nif = new System.Windows.Forms.Label();
            this.lbl_nomeUtilizador = new System.Windows.Forms.Label();
            this.lbl_palavraPasse = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_sobrenome = new System.Windows.Forms.TextBox();
            this.txb_idTipoUtilizador = new System.Windows.Forms.TextBox();
            this.txb_dataNascimento = new System.Windows.Forms.TextBox();
            this.txb_curso = new System.Windows.Forms.TextBox();
            this.txb_nif = new System.Windows.Forms.TextBox();
            this.txb_nomeUtilizador = new System.Windows.Forms.TextBox();
            this.txb_palavraPasse = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dados
            // 
            this.btn_dados.Location = new System.Drawing.Point(33, 293);
            this.btn_dados.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dados.Name = "btn_dados";
            this.btn_dados.Size = new System.Drawing.Size(85, 30);
            this.btn_dados.TabIndex = 1;
            this.btn_dados.Text = "Buscar Dados";
            this.btn_dados.UseVisualStyleBackColor = true;
            this.btn_dados.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(30, 30);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(30, 60);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(64, 13);
            this.lbl_sobrenome.TabIndex = 3;
            this.lbl_sobrenome.Text = "Sobrenome:";
            // 
            // lbl_idTipoUtilizador
            // 
            this.lbl_idTipoUtilizador.AutoSize = true;
            this.lbl_idTipoUtilizador.Location = new System.Drawing.Point(30, 90);
            this.lbl_idTipoUtilizador.Name = "lbl_idTipoUtilizador";
            this.lbl_idTipoUtilizador.Size = new System.Drawing.Size(91, 13);
            this.lbl_idTipoUtilizador.TabIndex = 4;
            this.lbl_idTipoUtilizador.Text = "ID Tipo Utilizador:";
            // 
            // lbl_dataNascimento
            // 
            this.lbl_dataNascimento.AutoSize = true;
            this.lbl_dataNascimento.Location = new System.Drawing.Point(30, 120);
            this.lbl_dataNascimento.Name = "lbl_dataNascimento";
            this.lbl_dataNascimento.Size = new System.Drawing.Size(92, 13);
            this.lbl_dataNascimento.TabIndex = 5;
            this.lbl_dataNascimento.Text = "Data Nascimento:";
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(30, 150);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(37, 13);
            this.lbl_curso.TabIndex = 6;
            this.lbl_curso.Text = "Curso:";
            // 
            // lbl_nif
            // 
            this.lbl_nif.AutoSize = true;
            this.lbl_nif.Location = new System.Drawing.Point(30, 180);
            this.lbl_nif.Name = "lbl_nif";
            this.lbl_nif.Size = new System.Drawing.Size(27, 13);
            this.lbl_nif.TabIndex = 7;
            this.lbl_nif.Text = "NIF:";
            // 
            // lbl_nomeUtilizador
            // 
            this.lbl_nomeUtilizador.AutoSize = true;
            this.lbl_nomeUtilizador.Location = new System.Drawing.Point(30, 210);
            this.lbl_nomeUtilizador.Name = "lbl_nomeUtilizador";
            this.lbl_nomeUtilizador.Size = new System.Drawing.Size(84, 13);
            this.lbl_nomeUtilizador.TabIndex = 8;
            this.lbl_nomeUtilizador.Text = "Nome Utilizador:";
            // 
            // lbl_palavraPasse
            // 
            this.lbl_palavraPasse.AutoSize = true;
            this.lbl_palavraPasse.Location = new System.Drawing.Point(30, 240);
            this.lbl_palavraPasse.Name = "lbl_palavraPasse";
            this.lbl_palavraPasse.Size = new System.Drawing.Size(78, 13);
            this.lbl_palavraPasse.TabIndex = 9;
            this.lbl_palavraPasse.Text = "Palavra Passe:";
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(227, 27);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(153, 20);
            this.txb_nome.TabIndex = 10;
            // 
            // txb_sobrenome
            // 
            this.txb_sobrenome.Location = new System.Drawing.Point(227, 57);
            this.txb_sobrenome.Name = "txb_sobrenome";
            this.txb_sobrenome.Size = new System.Drawing.Size(153, 20);
            this.txb_sobrenome.TabIndex = 11;
            // 
            // txb_idTipoUtilizador
            // 
            this.txb_idTipoUtilizador.Location = new System.Drawing.Point(227, 87);
            this.txb_idTipoUtilizador.Name = "txb_idTipoUtilizador";
            this.txb_idTipoUtilizador.Size = new System.Drawing.Size(153, 20);
            this.txb_idTipoUtilizador.TabIndex = 12;
            // 
            // txb_dataNascimento
            // 
            this.txb_dataNascimento.Location = new System.Drawing.Point(227, 117);
            this.txb_dataNascimento.Name = "txb_dataNascimento";
            this.txb_dataNascimento.Size = new System.Drawing.Size(153, 20);
            this.txb_dataNascimento.TabIndex = 13;
            // 
            // txb_curso
            // 
            this.txb_curso.Location = new System.Drawing.Point(227, 147);
            this.txb_curso.Name = "txb_curso";
            this.txb_curso.Size = new System.Drawing.Size(153, 20);
            this.txb_curso.TabIndex = 14;
            // 
            // txb_nif
            // 
            this.txb_nif.Enabled = false;
            this.txb_nif.Location = new System.Drawing.Point(227, 177);
            this.txb_nif.Name = "txb_nif";
            this.txb_nif.Size = new System.Drawing.Size(153, 20);
            this.txb_nif.TabIndex = 15;
            // 
            // txb_nomeUtilizador
            // 
            this.txb_nomeUtilizador.Location = new System.Drawing.Point(227, 207);
            this.txb_nomeUtilizador.Name = "txb_nomeUtilizador";
            this.txb_nomeUtilizador.Size = new System.Drawing.Size(153, 20);
            this.txb_nomeUtilizador.TabIndex = 16;
            // 
            // txb_palavraPasse
            // 
            this.txb_palavraPasse.Location = new System.Drawing.Point(227, 237);
            this.txb_palavraPasse.Name = "txb_palavraPasse";
            this.txb_palavraPasse.Size = new System.Drawing.Size(153, 20);
            this.txb_palavraPasse.TabIndex = 17;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(305, 293);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 29);
            this.btn_voltar.TabIndex = 18;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(133, 293);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(77, 30);
            this.btn_editar.TabIndex = 19;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(222, 292);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(77, 30);
            this.btn_apagar.TabIndex = 20;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 334);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txb_palavraPasse);
            this.Controls.Add(this.txb_nomeUtilizador);
            this.Controls.Add(this.txb_nif);
            this.Controls.Add(this.txb_curso);
            this.Controls.Add(this.txb_dataNascimento);
            this.Controls.Add(this.txb_idTipoUtilizador);
            this.Controls.Add(this.txb_sobrenome);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.lbl_palavraPasse);
            this.Controls.Add(this.lbl_nomeUtilizador);
            this.Controls.Add(this.lbl_nif);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.lbl_dataNascimento);
            this.Controls.Add(this.lbl_idTipoUtilizador);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_dados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dados;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_idTipoUtilizador;
        private System.Windows.Forms.Label lbl_dataNascimento;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Label lbl_nif;
        private System.Windows.Forms.Label lbl_nomeUtilizador;
        private System.Windows.Forms.Label lbl_palavraPasse;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_sobrenome;
        private System.Windows.Forms.TextBox txb_idTipoUtilizador;
        private System.Windows.Forms.TextBox txb_dataNascimento;
        private System.Windows.Forms.TextBox txb_curso;
        private System.Windows.Forms.TextBox txb_nif;
        private System.Windows.Forms.TextBox txb_nomeUtilizador;
        private System.Windows.Forms.TextBox txb_palavraPasse;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_apagar;
    }
}
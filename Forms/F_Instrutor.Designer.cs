namespace Academia_AMS
{
    partial class F_Instrutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Instrutor));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_CadastrarUsuario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Obs = new System.Windows.Forms.TextBox();
            this.txt_Contrato = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Contrato = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Servico = new System.Windows.Forms.Label();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.lbl_Obs = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.LBL_Telefone = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.PB_Foto = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Sair);
            this.panel2.Controls.Add(this.btn_CadastrarUsuario);
            this.panel2.Location = new System.Drawing.Point(1257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 245);
            this.panel2.TabIndex = 7;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Sair.AutoSize = true;
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.Location = new System.Drawing.Point(32, 128);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(99, 82);
            this.btn_Sair.TabIndex = 0;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_CadastrarUsuario
            // 
            this.btn_CadastrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_CadastrarUsuario.AutoSize = true;
            this.btn_CadastrarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CadastrarUsuario.BackgroundImage")));
            this.btn_CadastrarUsuario.Location = new System.Drawing.Point(32, 22);
            this.btn_CadastrarUsuario.Name = "btn_CadastrarUsuario";
            this.btn_CadastrarUsuario.Size = new System.Drawing.Size(99, 82);
            this.btn_CadastrarUsuario.TabIndex = 0;
            this.btn_CadastrarUsuario.UseVisualStyleBackColor = true;
            this.btn_CadastrarUsuario.Click += new System.EventHandler(this.btn_CadastrarUsuario_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.txt_Nome);
            this.panel3.Controls.Add(this.txt_Obs);
            this.panel3.Controls.Add(this.txt_Contrato);
            this.panel3.Controls.Add(this.txt_Senha);
            this.panel3.Controls.Add(this.txt_Salario);
            this.panel3.Controls.Add(this.txt_Cpf);
            this.panel3.Controls.Add(this.txt_Id);
            this.panel3.Controls.Add(this.lbl_Contrato);
            this.panel3.Controls.Add(this.lbl_Senha);
            this.panel3.Controls.Add(this.lbl_Servico);
            this.panel3.Controls.Add(this.lbl_Salario);
            this.panel3.Controls.Add(this.lbl_Obs);
            this.panel3.Controls.Add(this.lbl_Cpf);
            this.panel3.Controls.Add(this.lbl_Nome);
            this.panel3.Controls.Add(this.LBL_Telefone);
            this.panel3.Location = new System.Drawing.Point(256, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 346);
            this.panel3.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cliente",
            "Personal"});
            this.comboBox1.Location = new System.Drawing.Point(331, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nome.Location = new System.Drawing.Point(114, 75);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(666, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Obs
            // 
            this.txt_Obs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Obs.Location = new System.Drawing.Point(123, 194);
            this.txt_Obs.Multiline = true;
            this.txt_Obs.Name = "txt_Obs";
            this.txt_Obs.Size = new System.Drawing.Size(675, 145);
            this.txt_Obs.TabIndex = 1;
            // 
            // txt_Contrato
            // 
            this.txt_Contrato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Contrato.Location = new System.Drawing.Point(609, 123);
            this.txt_Contrato.Name = "txt_Contrato";
            this.txt_Contrato.Size = new System.Drawing.Size(124, 20);
            this.txt_Contrato.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Senha.Location = new System.Drawing.Point(580, 32);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(124, 20);
            this.txt_Senha.TabIndex = 1;
            // 
            // txt_Salario
            // 
            this.txt_Salario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Salario.Location = new System.Drawing.Point(358, 123);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(124, 20);
            this.txt_Salario.TabIndex = 1;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cpf.Location = new System.Drawing.Point(114, 121);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(124, 20);
            this.txt_Cpf.TabIndex = 1;
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Id.Location = new System.Drawing.Point(123, 34);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 1;
            // 
            // lbl_Contrato
            // 
            this.lbl_Contrato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Contrato.AutoSize = true;
            this.lbl_Contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contrato.Location = new System.Drawing.Point(504, 123);
            this.lbl_Contrato.Name = "lbl_Contrato";
            this.lbl_Contrato.Size = new System.Drawing.Size(90, 17);
            this.lbl_Contrato.TabIndex = 0;
            this.lbl_Contrato.Text = "CONTRATO:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(503, 32);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(59, 17);
            this.lbl_Senha.TabIndex = 0;
            this.lbl_Senha.Text = "SENHA:";
            // 
            // lbl_Servico
            // 
            this.lbl_Servico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Servico.AutoSize = true;
            this.lbl_Servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Servico.Location = new System.Drawing.Point(253, 34);
            this.lbl_Servico.Name = "lbl_Servico";
            this.lbl_Servico.Size = new System.Drawing.Size(72, 17);
            this.lbl_Servico.TabIndex = 0;
            this.lbl_Servico.Text = "SERVIÇO:";
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salario.Location = new System.Drawing.Point(281, 123);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(71, 17);
            this.lbl_Salario.TabIndex = 0;
            this.lbl_Salario.Text = "SALÁRIO:";
            // 
            // lbl_Obs
            // 
            this.lbl_Obs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Obs.AutoSize = true;
            this.lbl_Obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Obs.Location = new System.Drawing.Point(64, 195);
            this.lbl_Obs.Name = "lbl_Obs";
            this.lbl_Obs.Size = new System.Drawing.Size(41, 17);
            this.lbl_Obs.TabIndex = 0;
            this.lbl_Obs.Text = "OBS:";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cpf.Location = new System.Drawing.Point(55, 122);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(38, 17);
            this.lbl_Cpf.TabIndex = 0;
            this.lbl_Cpf.Text = "CPF:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(55, 75);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(53, 17);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "NOME:";
            // 
            // LBL_Telefone
            // 
            this.LBL_Telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Telefone.AutoSize = true;
            this.LBL_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Telefone.Location = new System.Drawing.Point(32, 35);
            this.LBL_Telefone.Name = "LBL_Telefone";
            this.LBL_Telefone.Size = new System.Drawing.Size(85, 17);
            this.LBL_Telefone.TabIndex = 0;
            this.LBL_Telefone.Text = "TELEFONE:";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(418, 41);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(544, 39);
            this.Lbl_Titulo.TabIndex = 6;
            this.Lbl_Titulo.Text = "CADASTRO DE INSTRUTORES";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cadastrar.AutoSize = true;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(495, 590);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(380, 89);
            this.btn_Cadastrar.TabIndex = 5;
            this.btn_Cadastrar.Text = "CADASTRAR";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // PB_Foto
            // 
            this.PB_Foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Foto.BackgroundImage")));
            this.PB_Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_Foto.Location = new System.Drawing.Point(30, 12);
            this.PB_Foto.Name = "PB_Foto";
            this.PB_Foto.Size = new System.Drawing.Size(122, 110);
            this.PB_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Foto.TabIndex = 4;
            this.PB_Foto.TabStop = false;
            // 
            // F_Instrutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 779);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.PB_Foto);
            this.Name = "F_Instrutor";
            this.Text = "F_Instrutor";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_CadastrarUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox txt_Nome;
        public System.Windows.Forms.TextBox txt_Obs;
        public System.Windows.Forms.TextBox txt_Contrato;
        public System.Windows.Forms.TextBox txt_Salario;
        public System.Windows.Forms.TextBox txt_Cpf;
        public System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Contrato;
        private System.Windows.Forms.Label lbl_Servico;
        private System.Windows.Forms.Label lbl_Salario;
        private System.Windows.Forms.Label lbl_Obs;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label LBL_Telefone;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.PictureBox PB_Foto;
        public System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Senha;
    }
}
namespace Academia_AMS
{
    partial class F_Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Pesquisar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Horario = new System.Windows.Forms.TextBox();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.txt_Obs = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.LBL_HORARIO = new System.Windows.Forms.Label();
            this.LBL_DATA = new System.Windows.Forms.Label();
            this.lbl_Obs = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.LBL_iD = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.PB_Foto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
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
            this.panel2.Controls.Add(this.btn_Cadastro);
            this.panel2.Controls.Add(this.btn_Sair);
            this.panel2.Controls.Add(this.btn_Excluir);
            this.panel2.Location = new System.Drawing.Point(1175, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 603);
            this.panel2.TabIndex = 8;
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Cadastro.AutoSize = true;
            this.btn_Cadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cadastro.BackgroundImage")));
            this.btn_Cadastro.Location = new System.Drawing.Point(38, 17);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(99, 82);
            this.btn_Cadastro.TabIndex = 0;
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Sair.AutoSize = true;
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.Location = new System.Drawing.Point(38, 388);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(99, 82);
            this.btn_Sair.TabIndex = 0;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Excluir.AutoSize = true;
            this.btn_Excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Excluir.BackgroundImage")));
            this.btn_Excluir.Location = new System.Drawing.Point(38, 222);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(99, 82);
            this.btn_Excluir.TabIndex = 0;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txt_Nome);
            this.panel3.Controls.Add(this.txt_Horario);
            this.panel3.Controls.Add(this.txt_Data);
            this.panel3.Controls.Add(this.txt_Obs);
            this.panel3.Controls.Add(this.txt_Telefone);
            this.panel3.Controls.Add(this.txt_Cpf);
            this.panel3.Controls.Add(this.LBL_HORARIO);
            this.panel3.Controls.Add(this.LBL_DATA);
            this.panel3.Controls.Add(this.lbl_Obs);
            this.panel3.Controls.Add(this.lbl_Telefone);
            this.panel3.Controls.Add(this.lbl_Nome);
            this.panel3.Controls.Add(this.LBL_iD);
            this.panel3.Location = new System.Drawing.Point(224, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 355);
            this.panel3.TabIndex = 9;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nome.Location = new System.Drawing.Point(114, 79);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(666, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Horario
            // 
            this.txt_Horario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Horario.Location = new System.Drawing.Point(565, 35);
            this.txt_Horario.Name = "txt_Horario";
            this.txt_Horario.Size = new System.Drawing.Size(100, 20);
            this.txt_Horario.TabIndex = 1;
            // 
            // txt_Data
            // 
            this.txt_Data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Data.Location = new System.Drawing.Point(335, 35);
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(100, 20);
            this.txt_Data.TabIndex = 1;
            // 
            // txt_Obs
            // 
            this.txt_Obs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Obs.Location = new System.Drawing.Point(114, 203);
            this.txt_Obs.Multiline = true;
            this.txt_Obs.Name = "txt_Obs";
            this.txt_Obs.Size = new System.Drawing.Size(675, 145);
            this.txt_Obs.TabIndex = 1;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cpf.Location = new System.Drawing.Point(123, 38);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_Cpf.TabIndex = 1;
            // 
            // LBL_HORARIO
            // 
            this.LBL_HORARIO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_HORARIO.AutoSize = true;
            this.LBL_HORARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HORARIO.Location = new System.Drawing.Point(483, 32);
            this.LBL_HORARIO.Name = "LBL_HORARIO";
            this.LBL_HORARIO.Size = new System.Drawing.Size(76, 17);
            this.LBL_HORARIO.TabIndex = 0;
            this.LBL_HORARIO.Text = "HORARIO:";
            // 
            // LBL_DATA
            // 
            this.LBL_DATA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_DATA.AutoSize = true;
            this.LBL_DATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DATA.Location = new System.Drawing.Point(261, 32);
            this.LBL_DATA.Name = "LBL_DATA";
            this.LBL_DATA.Size = new System.Drawing.Size(49, 17);
            this.LBL_DATA.TabIndex = 0;
            this.LBL_DATA.Text = "DATA:";
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
            // LBL_iD
            // 
            this.LBL_iD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_iD.AutoSize = true;
            this.LBL_iD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_iD.Location = new System.Drawing.Point(79, 38);
            this.LBL_iD.Name = "LBL_iD";
            this.LBL_iD.Size = new System.Drawing.Size(38, 17);
            this.LBL_iD.TabIndex = 0;
            this.LBL_iD.Text = "CPF:";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(386, 31);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(459, 39);
            this.Lbl_Titulo.TabIndex = 7;
            this.Lbl_Titulo.Text = "PESQUISA DE USUÁRIOS";
            // 
            // PB_Foto
            // 
            this.PB_Foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Foto.BackgroundImage")));
            this.PB_Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_Foto.Location = new System.Drawing.Point(12, 12);
            this.PB_Foto.Name = "PB_Foto";
            this.PB_Foto.Size = new System.Drawing.Size(122, 110);
            this.PB_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_Foto.TabIndex = 4;
            this.PB_Foto.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "DIGITE O NOME OU CPF:";
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Pesquisa.Location = new System.Drawing.Point(587, 131);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(262, 20);
            this.txt_Pesquisa.TabIndex = 1;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.Location = new System.Drawing.Point(528, 192);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(237, 47);
            this.btn_Pesquisar.TabIndex = 10;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefone.Location = new System.Drawing.Point(279, 142);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(85, 17);
            this.lbl_Telefone.TabIndex = 0;
            this.lbl_Telefone.Text = "TELEFONE:";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Telefone.Location = new System.Drawing.Point(370, 142);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefone.TabIndex = 1;
            // 
            // F_Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 710);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_Pesquisa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.PB_Foto);
            this.Name = "F_Pesquisar";
            this.Text = "F_Pesquisar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Pesquisar_FormClosed);
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
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Horario;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.TextBox txt_Obs;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.Label LBL_HORARIO;
        private System.Windows.Forms.Label LBL_DATA;
        private System.Windows.Forms.Label lbl_Obs;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label LBL_iD;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.PictureBox PB_Foto;
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Pesquisa;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label lbl_Telefone;
    }
}
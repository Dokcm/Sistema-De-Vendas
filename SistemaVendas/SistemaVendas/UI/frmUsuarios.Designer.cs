namespace SistemaVendas.UI
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.dvgusuarios = new System.Windows.Forms.DataGridView();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txts_nome = new System.Windows.Forms.TextBox();
            this.lblsobrenome = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtcontato = new System.Windows.Forms.TextBox();
            this.lblcontato = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblendereço = new System.Windows.Forms.Label();
            this.lbltipousuario = new System.Windows.Forms.Label();
            this.cmbtipousuario = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(318, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRO DE USUARIOS";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(930, 30);
            this.pnlTop.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(900, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(12, 37);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(31, 19);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "ID :";
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(117, 37);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(74, 20);
            this.txtid.TabIndex = 4;
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbsexo.Location = new System.Drawing.Point(117, 115);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(250, 21);
            this.cmbsexo.TabIndex = 5;
            // 
            // dvgusuarios
            // 
            this.dvgusuarios.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dvgusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgusuarios.Location = new System.Drawing.Point(373, 63);
            this.dvgusuarios.Name = "dvgusuarios";
            this.dvgusuarios.Size = new System.Drawing.Size(545, 277);
            this.dvgusuarios.TabIndex = 6;
            this.dvgusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgusuarios_CellContentClick);
            this.dvgusuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgusuarios_RowHeaderMouseClick);
            // 
            // txtnome
            // 
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.Location = new System.Drawing.Point(117, 63);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(250, 20);
            this.txtnome.TabIndex = 8;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(12, 63);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(58, 19);
            this.lblnome.TabIndex = 7;
            this.lblnome.Text = "Nome :";
            // 
            // txts_nome
            // 
            this.txts_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txts_nome.Location = new System.Drawing.Point(117, 89);
            this.txts_nome.Name = "txts_nome";
            this.txts_nome.Size = new System.Drawing.Size(250, 20);
            this.txts_nome.TabIndex = 10;
            // 
            // lblsobrenome
            // 
            this.lblsobrenome.AutoSize = true;
            this.lblsobrenome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsobrenome.Location = new System.Drawing.Point(12, 89);
            this.lblsobrenome.Name = "lblsobrenome";
            this.lblsobrenome.Size = new System.Drawing.Size(96, 19);
            this.lblsobrenome.TabIndex = 9;
            this.lblsobrenome.Text = "Sobrenome :";
            // 
            // txtusuario
            // 
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusuario.Location = new System.Drawing.Point(117, 295);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(250, 20);
            this.txtusuario.TabIndex = 14;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(12, 295);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(69, 19);
            this.lblusuario.TabIndex = 13;
            this.lblusuario.Text = "Usuario :";
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Location = new System.Drawing.Point(117, 142);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(250, 20);
            this.txtemail.TabIndex = 12;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(12, 142);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(54, 19);
            this.lblemail.TabIndex = 11;
            this.lblemail.Text = "Email :";
            // 
            // txtcontato
            // 
            this.txtcontato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontato.Location = new System.Drawing.Point(117, 168);
            this.txtcontato.Name = "txtcontato";
            this.txtcontato.Size = new System.Drawing.Size(250, 20);
            this.txtcontato.TabIndex = 18;
            // 
            // lblcontato
            // 
            this.lblcontato.AutoSize = true;
            this.lblcontato.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontato.Location = new System.Drawing.Point(12, 168);
            this.lblcontato.Name = "lblcontato";
            this.lblcontato.Size = new System.Drawing.Size(72, 19);
            this.lblcontato.TabIndex = 17;
            this.lblcontato.Text = "Contato :";
            // 
            // txtsenha
            // 
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenha.Location = new System.Drawing.Point(117, 321);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(250, 20);
            this.txtsenha.TabIndex = 16;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(12, 321);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(59, 19);
            this.lblsenha.TabIndex = 15;
            this.lblsenha.Text = "Senha :";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(12, 117);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(49, 19);
            this.lblsexo.TabIndex = 21;
            this.lblsexo.Text = "Sexo :";
            // 
            // txtendereco
            // 
            this.txtendereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtendereco.Location = new System.Drawing.Point(117, 194);
            this.txtendereco.Multiline = true;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(250, 68);
            this.txtendereco.TabIndex = 20;
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereço.Location = new System.Drawing.Point(12, 194);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(81, 19);
            this.lblendereço.TabIndex = 19;
            this.lblendereço.Text = "Endereço :";
            // 
            // lbltipousuario
            // 
            this.lbltipousuario.AutoSize = true;
            this.lbltipousuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipousuario.Location = new System.Drawing.Point(12, 268);
            this.lbltipousuario.Name = "lbltipousuario";
            this.lbltipousuario.Size = new System.Drawing.Size(103, 19);
            this.lbltipousuario.TabIndex = 25;
            this.lbltipousuario.Text = "Tipo Usuario :";
            // 
            // cmbtipousuario
            // 
            this.cmbtipousuario.FormattingEnabled = true;
            this.cmbtipousuario.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.cmbtipousuario.Location = new System.Drawing.Point(117, 268);
            this.cmbtipousuario.Name = "cmbtipousuario";
            this.cmbtipousuario.Size = new System.Drawing.Size(250, 21);
            this.cmbtipousuario.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(518, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "Pesquisar Usuarios :";
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpesquisar.Location = new System.Drawing.Point(668, 37);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(250, 20);
            this.txtpesquisar.TabIndex = 29;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.LawnGreen;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(373, 346);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(155, 47);
            this.btncadastrar.TabIndex = 30;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnatualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(568, 346);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(155, 47);
            this.btnatualizar.TabIndex = 31;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Red;
            this.btndeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeletar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.Location = new System.Drawing.Point(763, 346);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(155, 47);
            this.btndeletar.TabIndex = 32;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 400);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbtipousuario);
            this.Controls.Add(this.lbltipousuario);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.txtcontato);
            this.Controls.Add(this.lblcontato);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txts_nome);
            this.Controls.Add(this.lblsobrenome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.dvgusuarios);
            this.Controls.Add(this.cmbsexo);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.DataGridView dvgusuarios;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txts_nome;
        private System.Windows.Forms.Label lblsobrenome;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtcontato;
        private System.Windows.Forms.Label lblcontato;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblendereço;
        private System.Windows.Forms.Label lbltipousuario;
        private System.Windows.Forms.ComboBox cmbtipousuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btndeletar;
    }
}
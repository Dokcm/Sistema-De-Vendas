namespace SistemaVendas.UI
{
    partial class frmclisdis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmclisdis));
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtclisdispesquisar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbclisdistipo = new System.Windows.Forms.ComboBox();
            this.lbltipousuario = new System.Windows.Forms.Label();
            this.txtclisdisendereco = new System.Windows.Forms.TextBox();
            this.lblendereço = new System.Windows.Forms.Label();
            this.txtclisdiscontato = new System.Windows.Forms.TextBox();
            this.lblcontato = new System.Windows.Forms.Label();
            this.txtclisdisemail = new System.Windows.Forms.TextBox();
            this.txtclisdisnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.dvgclisdisusuarios = new System.Windows.Forms.DataGridView();
            this.txtclidisid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvgclisdisusuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Red;
            this.btndeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeletar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.Location = new System.Drawing.Point(318, 356);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(89, 35);
            this.btndeletar.TabIndex = 52;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnatualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(205, 356);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(89, 35);
            this.btnatualizar.TabIndex = 51;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.LawnGreen;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(91, 356);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(89, 35);
            this.btncadastrar.TabIndex = 50;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txtclisdispesquisar
            // 
            this.txtclisdispesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclisdispesquisar.Location = new System.Drawing.Point(650, 40);
            this.txtclisdispesquisar.Name = "txtclisdispesquisar";
            this.txtclisdispesquisar.Size = new System.Drawing.Size(268, 20);
            this.txtclisdispesquisar.TabIndex = 49;
            this.txtclisdispesquisar.TextChanged += new System.EventHandler(this.txtclisdispesquisar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(409, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 19);
            this.label12.TabIndex = 48;
            this.label12.Text = "Pesquisar Distribuidora/Cliente :";
            // 
            // cmbclisdistipo
            // 
            this.cmbclisdistipo.FormattingEnabled = true;
            this.cmbclisdistipo.Items.AddRange(new object[] {
            "Distribuidora",
            "Cliente"});
            this.cmbclisdistipo.Location = new System.Drawing.Point(91, 66);
            this.cmbclisdistipo.Name = "cmbclisdistipo";
            this.cmbclisdistipo.Size = new System.Drawing.Size(316, 21);
            this.cmbclisdistipo.TabIndex = 47;
            // 
            // lbltipousuario
            // 
            this.lbltipousuario.AutoSize = true;
            this.lbltipousuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipousuario.Location = new System.Drawing.Point(8, 66);
            this.lbltipousuario.Name = "lbltipousuario";
            this.lbltipousuario.Size = new System.Drawing.Size(47, 19);
            this.lbltipousuario.TabIndex = 46;
            this.lbltipousuario.Text = "Tipo :";
            // 
            // txtclisdisendereco
            // 
            this.txtclisdisendereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclisdisendereco.Location = new System.Drawing.Point(91, 171);
            this.txtclisdisendereco.Multiline = true;
            this.txtclisdisendereco.Name = "txtclisdisendereco";
            this.txtclisdisendereco.Size = new System.Drawing.Size(316, 179);
            this.txtclisdisendereco.TabIndex = 45;
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereço.Location = new System.Drawing.Point(8, 171);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(81, 19);
            this.lblendereço.TabIndex = 44;
            this.lblendereço.Text = "Endereço :";
            // 
            // txtclisdiscontato
            // 
            this.txtclisdiscontato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclisdiscontato.Location = new System.Drawing.Point(91, 145);
            this.txtclisdiscontato.Name = "txtclisdiscontato";
            this.txtclisdiscontato.Size = new System.Drawing.Size(316, 20);
            this.txtclisdiscontato.TabIndex = 43;
            // 
            // lblcontato
            // 
            this.lblcontato.AutoSize = true;
            this.lblcontato.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontato.Location = new System.Drawing.Point(8, 145);
            this.lblcontato.Name = "lblcontato";
            this.lblcontato.Size = new System.Drawing.Size(72, 19);
            this.lblcontato.TabIndex = 42;
            this.lblcontato.Text = "Contato :";
            // 
            // txtclisdisemail
            // 
            this.txtclisdisemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclisdisemail.Location = new System.Drawing.Point(91, 119);
            this.txtclisdisemail.Name = "txtclisdisemail";
            this.txtclisdisemail.Size = new System.Drawing.Size(316, 20);
            this.txtclisdisemail.TabIndex = 41;
            // 
            // txtclisdisnome
            // 
            this.txtclisdisnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclisdisnome.Location = new System.Drawing.Point(91, 93);
            this.txtclisdisnome.Name = "txtclisdisnome";
            this.txtclisdisnome.Size = new System.Drawing.Size(316, 20);
            this.txtclisdisnome.TabIndex = 39;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(8, 93);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(58, 19);
            this.lblnome.TabIndex = 38;
            this.lblnome.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(260, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Distribuidora/Cliente : ";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(8, 119);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(54, 19);
            this.lblemail.TabIndex = 40;
            this.lblemail.Text = "Email :";
            // 
            // dvgclisdisusuarios
            // 
            this.dvgclisdisusuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgclisdisusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgclisdisusuarios.Location = new System.Drawing.Point(413, 67);
            this.dvgclisdisusuarios.Name = "dvgclisdisusuarios";
            this.dvgclisdisusuarios.Size = new System.Drawing.Size(505, 324);
            this.dvgclisdisusuarios.TabIndex = 37;
            this.dvgclisdisusuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgclisdisusuarios_RowHeaderMouseClick);
            // 
            // txtclidisid
            // 
            this.txtclidisid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtclidisid.Location = new System.Drawing.Point(199, 40);
            this.txtclidisid.Name = "txtclidisid";
            this.txtclidisid.ReadOnly = true;
            this.txtclidisid.Size = new System.Drawing.Size(208, 20);
            this.txtclidisid.TabIndex = 36;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(8, 40);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(179, 19);
            this.lblid.TabIndex = 35;
            this.lblid.Text = "Distribuidora/Cliente ID :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(900, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(930, 30);
            this.pnlTop.TabIndex = 33;
            // 
            // frmclisdis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 400);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtclisdispesquisar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbclisdistipo);
            this.Controls.Add(this.lbltipousuario);
            this.Controls.Add(this.txtclisdisendereco);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.txtclisdiscontato);
            this.Controls.Add(this.lblcontato);
            this.Controls.Add(this.txtclisdisemail);
            this.Controls.Add(this.txtclisdisnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.dvgclisdisusuarios);
            this.Controls.Add(this.txtclidisid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.pnlTop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmclisdis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmclisdis";
            this.Load += new System.EventHandler(this.frmclisdis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgclisdisusuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txtclisdispesquisar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbclisdistipo;
        private System.Windows.Forms.Label lbltipousuario;
        private System.Windows.Forms.TextBox txtclisdisendereco;
        private System.Windows.Forms.Label lblendereço;
        private System.Windows.Forms.TextBox txtclisdiscontato;
        private System.Windows.Forms.Label lblcontato;
        private System.Windows.Forms.TextBox txtclisdisemail;
        private System.Windows.Forms.TextBox txtclisdisnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.DataGridView dvgclisdisusuarios;
        private System.Windows.Forms.TextBox txtclidisid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTop;
    }
}
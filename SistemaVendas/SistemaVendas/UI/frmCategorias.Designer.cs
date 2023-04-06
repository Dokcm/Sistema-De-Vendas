namespace SistemaVendas.UI
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcatdescricao = new System.Windows.Forms.TextBox();
            this.lblendereço = new System.Windows.Forms.Label();
            this.txtcattitulo = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.dvgcategorias = new System.Windows.Forms.DataGridView();
            this.txtcatid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTop.Controls.Add(this.pictureBox2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(930, 30);
            this.pnlTop.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(846, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(302, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Categorias";
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Red;
            this.btndeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeletar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.Location = new System.Drawing.Point(281, 352);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(118, 36);
            this.btndeletar.TabIndex = 58;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click_1);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnatualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(147, 352);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(118, 36);
            this.btnatualizar.TabIndex = 57;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click_1);
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.LawnGreen;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(12, 352);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(118, 36);
            this.btncadastrar.TabIndex = 56;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click_1);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpesquisar.Location = new System.Drawing.Point(566, 50);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(352, 20);
            this.txtpesquisar.TabIndex = 55;
            this.txtpesquisar.TextChanged += new System.EventHandler(this.txtpesquisar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(409, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 19);
            this.label12.TabIndex = 54;
            this.label12.Text = "Pesquisar Categoria :";
            // 
            // txtcatdescricao
            // 
            this.txtcatdescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcatdescricao.Location = new System.Drawing.Point(153, 102);
            this.txtcatdescricao.Multiline = true;
            this.txtcatdescricao.Name = "txtcatdescricao";
            this.txtcatdescricao.Size = new System.Drawing.Size(250, 195);
            this.txtcatdescricao.TabIndex = 50;
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereço.Location = new System.Drawing.Point(12, 100);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(82, 19);
            this.lblendereço.TabIndex = 49;
            this.lblendereço.Text = "Descricao :";
            // 
            // txtcattitulo
            // 
            this.txtcattitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcattitulo.Location = new System.Drawing.Point(153, 76);
            this.txtcattitulo.Name = "txtcattitulo";
            this.txtcattitulo.Size = new System.Drawing.Size(250, 20);
            this.txtcattitulo.TabIndex = 38;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(12, 74);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(126, 19);
            this.lblnome.TabIndex = 37;
            this.lblnome.Text = "Titulo Categoria :";
            // 
            // dvgcategorias
            // 
            this.dvgcategorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcategorias.Location = new System.Drawing.Point(411, 74);
            this.dvgcategorias.Name = "dvgcategorias";
            this.dvgcategorias.Size = new System.Drawing.Size(507, 314);
            this.dvgcategorias.TabIndex = 36;
            this.dvgcategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgcategorias_CellContentClick);
            this.dvgcategorias.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgusuarios_RowHeaderMouseClick);
            // 
            // txtcatid
            // 
            this.txtcatid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcatid.Location = new System.Drawing.Point(153, 50);
            this.txtcatid.Name = "txtcatid";
            this.txtcatid.ReadOnly = true;
            this.txtcatid.Size = new System.Drawing.Size(250, 20);
            this.txtcatid.TabIndex = 34;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(12, 51);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(100, 19);
            this.lblid.TabIndex = 33;
            this.lblid.Text = "Categoria ID :";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 400);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcatdescricao);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.txtcattitulo);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.dvgcategorias);
            this.Controls.Add(this.txtcatid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorias";
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcatdescricao;
        private System.Windows.Forms.Label lblendereço;
        private System.Windows.Forms.TextBox txtcattitulo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.DataGridView dvgcategorias;
        private System.Windows.Forms.TextBox txtcatid;
        private System.Windows.Forms.Label lblid;
    }
}
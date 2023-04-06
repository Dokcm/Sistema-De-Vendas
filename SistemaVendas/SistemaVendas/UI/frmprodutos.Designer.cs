namespace SistemaVendas.UI
{
    partial class frmprodutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprodutos));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtprodpesquisar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtproddescricao = new System.Windows.Forms.TextBox();
            this.lblendereço = new System.Windows.Forms.Label();
            this.txtprodnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.dvgprodutos = new System.Windows.Forms.DataGridView();
            this.txtprodid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txtprodavaliacao = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgprodutos)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(876, 30);
            this.pnlTop.TabIndex = 59;
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
            this.label1.Location = new System.Drawing.Point(310, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Red;
            this.btndeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeletar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.Location = new System.Drawing.Point(285, 338);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(118, 35);
            this.btndeletar.TabIndex = 71;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click_1);
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnatualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.Location = new System.Drawing.Point(151, 338);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(118, 35);
            this.btnatualizar.TabIndex = 70;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.LawnGreen;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(16, 338);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(118, 35);
            this.btncadastrar.TabIndex = 69;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txtprodpesquisar
            // 
            this.txtprodpesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprodpesquisar.Location = new System.Drawing.Point(566, 73);
            this.txtprodpesquisar.Name = "txtprodpesquisar";
            this.txtprodpesquisar.Size = new System.Drawing.Size(298, 20);
            this.txtprodpesquisar.TabIndex = 68;
            this.txtprodpesquisar.TextChanged += new System.EventHandler(this.txtprodpesquisar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(407, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 19);
            this.label12.TabIndex = 67;
            this.label12.Text = "Pesquisar Produto :";
            // 
            // txtproddescricao
            // 
            this.txtproddescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproddescricao.Location = new System.Drawing.Point(151, 151);
            this.txtproddescricao.Multiline = true;
            this.txtproddescricao.Name = "txtproddescricao";
            this.txtproddescricao.Size = new System.Drawing.Size(250, 144);
            this.txtproddescricao.TabIndex = 66;
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereço.Location = new System.Drawing.Point(10, 149);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(82, 19);
            this.lblendereço.TabIndex = 65;
            this.lblendereço.Text = "Descricao :";
            // 
            // txtprodnome
            // 
            this.txtprodnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprodnome.Location = new System.Drawing.Point(151, 99);
            this.txtprodnome.Name = "txtprodnome";
            this.txtprodnome.Size = new System.Drawing.Size(250, 20);
            this.txtprodnome.TabIndex = 64;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(10, 99);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(119, 19);
            this.lblnome.TabIndex = 63;
            this.lblnome.Text = "Nome Produto :";
            // 
            // dvgprodutos
            // 
            this.dvgprodutos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dvgprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgprodutos.Location = new System.Drawing.Point(411, 97);
            this.dvgprodutos.Name = "dvgprodutos";
            this.dvgprodutos.Size = new System.Drawing.Size(453, 276);
            this.dvgprodutos.TabIndex = 62;
            this.dvgprodutos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgcategorias_RowHeaderMouseClick);
            // 
            // txtprodid
            // 
            this.txtprodid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprodid.Location = new System.Drawing.Point(151, 73);
            this.txtprodid.Name = "txtprodid";
            this.txtprodid.ReadOnly = true;
            this.txtprodid.Size = new System.Drawing.Size(250, 20);
            this.txtprodid.TabIndex = 61;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(10, 73);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(92, 19);
            this.lblid.TabIndex = 60;
            this.lblid.Text = "Produto ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Categoria  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 73;
            this.label3.Text = "Avaliacao :";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(151, 124);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(250, 21);
            this.cmbcategoria.TabIndex = 75;
            // 
            // txtprodavaliacao
            // 
            this.txtprodavaliacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprodavaliacao.Location = new System.Drawing.Point(151, 301);
            this.txtprodavaliacao.Name = "txtprodavaliacao";
            this.txtprodavaliacao.Size = new System.Drawing.Size(250, 20);
            this.txtprodavaliacao.TabIndex = 76;
            // 
            // frmprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 405);
            this.Controls.Add(this.txtprodavaliacao);
            this.Controls.Add(this.cmbcategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtprodpesquisar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtproddescricao);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.txtprodnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.dvgprodutos);
            this.Controls.Add(this.txtprodid);
            this.Controls.Add(this.lblid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmprodutos";
            this.Text = "frmprodutos";
            this.Load += new System.EventHandler(this.frmprodutos_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgprodutos)).EndInit();
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
        private System.Windows.Forms.TextBox txtprodpesquisar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtproddescricao;
        private System.Windows.Forms.Label lblendereço;
        private System.Windows.Forms.TextBox txtprodnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.DataGridView dvgprodutos;
        private System.Windows.Forms.TextBox txtprodid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.TextBox txtprodavaliacao;
    }
}
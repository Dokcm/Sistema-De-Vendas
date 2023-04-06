namespace SistemaVendas.UI
{
    partial class frmCompraVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraVenda));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtpesqCV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtenderecoCV = new System.Windows.Forms.TextBox();
            this.lblendereço = new System.Windows.Forms.Label();
            this.txtcontatoCV = new System.Windows.Forms.TextBox();
            this.lblcontato = new System.Windows.Forms.Label();
            this.txtemailCV = new System.Windows.Forms.TextBox();
            this.txtnomeCV = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dvgCV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpesqDPCV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnomeDP = new System.Windows.Forms.TextBox();
            this.txtinventarioDP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtavaliacaoDP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquantidadeDP = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txttotalpago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtvalortotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtimposto = new System.Windows.Forms.TextBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnsalvarDetalhes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(500, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compras / Vendas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1192, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
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
            this.pnlTop.Size = new System.Drawing.Size(1242, 50);
            this.pnlTop.TabIndex = 34;
            // 
            // txtpesqCV
            // 
            this.txtpesqCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpesqCV.Location = new System.Drawing.Point(123, 97);
            this.txtpesqCV.Name = "txtpesqCV";
            this.txtpesqCV.Size = new System.Drawing.Size(473, 20);
            this.txtpesqCV.TabIndex = 51;
            this.txtpesqCV.TextChanged += new System.EventHandler(this.txtclisdispesquisar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 50;
            this.label12.Text = "Pesquisar :";
            // 
            // txtenderecoCV
            // 
            this.txtenderecoCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtenderecoCV.Location = new System.Drawing.Point(123, 201);
            this.txtenderecoCV.Multiline = true;
            this.txtenderecoCV.Name = "txtenderecoCV";
            this.txtenderecoCV.Size = new System.Drawing.Size(473, 98);
            this.txtenderecoCV.TabIndex = 59;
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereço.Location = new System.Drawing.Point(27, 201);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(81, 19);
            this.lblendereço.TabIndex = 58;
            this.lblendereço.Text = "Endereço :";
            // 
            // txtcontatoCV
            // 
            this.txtcontatoCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontatoCV.Location = new System.Drawing.Point(123, 175);
            this.txtcontatoCV.Name = "txtcontatoCV";
            this.txtcontatoCV.Size = new System.Drawing.Size(473, 20);
            this.txtcontatoCV.TabIndex = 57;
            // 
            // lblcontato
            // 
            this.lblcontato.AutoSize = true;
            this.lblcontato.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontato.Location = new System.Drawing.Point(27, 176);
            this.lblcontato.Name = "lblcontato";
            this.lblcontato.Size = new System.Drawing.Size(72, 19);
            this.lblcontato.TabIndex = 56;
            this.lblcontato.Text = "Contato :";
            // 
            // txtemailCV
            // 
            this.txtemailCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemailCV.Location = new System.Drawing.Point(123, 149);
            this.txtemailCV.Name = "txtemailCV";
            this.txtemailCV.Size = new System.Drawing.Size(473, 20);
            this.txtemailCV.TabIndex = 55;
            // 
            // txtnomeCV
            // 
            this.txtnomeCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeCV.Location = new System.Drawing.Point(123, 123);
            this.txtnomeCV.Name = "txtnomeCV";
            this.txtnomeCV.Size = new System.Drawing.Size(473, 20);
            this.txtnomeCV.TabIndex = 53;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(27, 124);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(58, 19);
            this.lblnome.TabIndex = 52;
            this.lblnome.Text = "Nome :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(332, 151);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(54, 19);
            this.lblemail.TabIndex = 54;
            this.lblemail.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "Data :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 305);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(473, 20);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // dvgCV
            // 
            this.dvgCV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dvgCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCV.Location = new System.Drawing.Point(27, 393);
            this.dvgCV.Name = "dvgCV";
            this.dvgCV.Size = new System.Drawing.Size(569, 253);
            this.dvgCV.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 81;
            this.label9.Text = "Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(647, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Pesquisar";
            // 
            // txtpesqDPCV
            // 
            this.txtpesqDPCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpesqDPCV.Location = new System.Drawing.Point(745, 97);
            this.txtpesqDPCV.Name = "txtpesqDPCV";
            this.txtpesqDPCV.Size = new System.Drawing.Size(473, 20);
            this.txtpesqDPCV.TabIndex = 64;
            this.txtpesqDPCV.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 67;
            this.label7.Text = "Inventario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Nome :";
            // 
            // txtnomeDP
            // 
            this.txtnomeDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeDP.Location = new System.Drawing.Point(745, 123);
            this.txtnomeDP.Name = "txtnomeDP";
            this.txtnomeDP.Size = new System.Drawing.Size(473, 20);
            this.txtnomeDP.TabIndex = 66;
            // 
            // txtinventarioDP
            // 
            this.txtinventarioDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtinventarioDP.Location = new System.Drawing.Point(745, 149);
            this.txtinventarioDP.Name = "txtinventarioDP";
            this.txtinventarioDP.Size = new System.Drawing.Size(473, 20);
            this.txtinventarioDP.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 77;
            this.label3.Text = "Avaliacao :";
            // 
            // txtavaliacaoDP
            // 
            this.txtavaliacaoDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtavaliacaoDP.Location = new System.Drawing.Point(745, 178);
            this.txtavaliacaoDP.Name = "txtavaliacaoDP";
            this.txtavaliacaoDP.Size = new System.Drawing.Size(473, 20);
            this.txtavaliacaoDP.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "Quantidade :";
            // 
            // txtquantidadeDP
            // 
            this.txtquantidadeDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantidadeDP.Location = new System.Drawing.Point(745, 204);
            this.txtquantidadeDP.Name = "txtquantidadeDP";
            this.txtquantidadeDP.Size = new System.Drawing.Size(473, 20);
            this.txtquantidadeDP.TabIndex = 80;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btncadastrar.Location = new System.Drawing.Point(745, 280);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(473, 45);
            this.btncadastrar.TabIndex = 82;
            this.btncadastrar.Text = "Adicionar Detalhes do Produto";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txttroco
            // 
            this.txttroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttroco.Location = new System.Drawing.Point(745, 523);
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(473, 20);
            this.txttroco.TabIndex = 94;
            this.txttroco.TextChanged += new System.EventHandler(this.txttroco_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(649, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 93;
            this.label10.Text = "Troco";
            // 
            // txttotalpago
            // 
            this.txttotalpago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalpago.Location = new System.Drawing.Point(745, 497);
            this.txttotalpago.Name = "txttotalpago";
            this.txttotalpago.Size = new System.Drawing.Size(473, 20);
            this.txttotalpago.TabIndex = 92;
            this.txttotalpago.TextChanged += new System.EventHandler(this.txttotalpago_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(649, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 91;
            this.label11.Text = "Total Pago :";
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalortotal.Location = new System.Drawing.Point(745, 471);
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.Size = new System.Drawing.Size(473, 20);
            this.txtvalortotal.TabIndex = 90;
            this.txtvalortotal.TextChanged += new System.EventHandler(this.txtvalortotal_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(649, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 19);
            this.label13.TabIndex = 89;
            this.label13.Text = "Valor Total :";
            // 
            // txtimposto
            // 
            this.txtimposto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtimposto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtimposto.Location = new System.Drawing.Point(745, 445);
            this.txtimposto.Name = "txtimposto";
            this.txtimposto.Size = new System.Drawing.Size(473, 20);
            this.txtimposto.TabIndex = 88;
            this.txtimposto.TextChanged += new System.EventHandler(this.txtimposto_TextChanged);
            // 
            // txtdesconto
            // 
            this.txtdesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesconto.Location = new System.Drawing.Point(745, 419);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(473, 20);
            this.txtdesconto.TabIndex = 86;
            this.txtdesconto.TextChanged += new System.EventHandler(this.txtdesconto_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(649, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 85;
            this.label14.Text = "Desconto :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(649, 446);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(73, 19);
            this.label15.TabIndex = 87;
            this.label15.Text = "Imposto :";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsubtotal.Location = new System.Drawing.Point(745, 393);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(473, 20);
            this.txtsubtotal.TabIndex = 84;
            this.txtsubtotal.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(649, 394);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 19);
            this.label16.TabIndex = 83;
            this.label16.Text = "Sub Total :";
            // 
            // btnsalvarDetalhes
            // 
            this.btnsalvarDetalhes.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsalvarDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalvarDetalhes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvarDetalhes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalvarDetalhes.Location = new System.Drawing.Point(745, 601);
            this.btnsalvarDetalhes.Name = "btnsalvarDetalhes";
            this.btnsalvarDetalhes.Size = new System.Drawing.Size(473, 45);
            this.btnsalvarDetalhes.TabIndex = 95;
            this.btnsalvarDetalhes.Text = "Cadastrar Detalhes da Compra/ Venda";
            this.btnsalvarDetalhes.UseVisualStyleBackColor = false;
            this.btnsalvarDetalhes.Click += new System.EventHandler(this.btnsalvarDetalhes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 27);
            this.label5.TabIndex = 96;
            this.label5.Text = "Detalhes Distribuidora/Cliente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(880, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(203, 27);
            this.label17.TabIndex = 97;
            this.label17.Text = "Detalhes do Produto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(204, 364);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(214, 27);
            this.label18.TabIndex = 98;
            this.label18.Text = "Produtos Adicionados";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(845, 364);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(273, 27);
            this.label19.TabIndex = 99;
            this.label19.Text = "Detalhes da compra / Venda";
            // 
            // frmCompraVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 666);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsalvarDetalhes);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txttotalpago);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtvalortotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtimposto);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtquantidadeDP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtavaliacaoDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtinventarioDP);
            this.Controls.Add(this.txtnomeDP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpesqDPCV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dvgCV);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtenderecoCV);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.txtcontatoCV);
            this.Controls.Add(this.lblcontato);
            this.Controls.Add(this.txtemailCV);
            this.Controls.Add(this.txtnomeCV);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtpesqCV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompraVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCompraVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtpesqCV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtenderecoCV;
        private System.Windows.Forms.Label lblendereço;
        private System.Windows.Forms.TextBox txtcontatoCV;
        private System.Windows.Forms.Label lblcontato;
        private System.Windows.Forms.TextBox txtemailCV;
        private System.Windows.Forms.TextBox txtnomeCV;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dvgCV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpesqDPCV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnomeDP;
        private System.Windows.Forms.TextBox txtinventarioDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtavaliacaoDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquantidadeDP;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttotalpago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtvalortotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtimposto;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnsalvarDetalhes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}
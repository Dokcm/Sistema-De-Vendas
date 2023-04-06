using DGVPrinterHelper;
using SistemaVendas.BLL;
using SistemaVendas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SistemaVendas.UI
{
    public partial class frmCompraVenda : Form
    {
        public frmCompraVenda()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CliDisDAL dcDAL = new CliDisDAL();
        produtosDAL pDAL = new produtosDAL();
        DataTable transacaoDT = new DataTable();
        transacaoDAL tDAL = new transacaoDAL();
        transacaodetalhesDAL tdDAL = new transacaodetalhesDAL();

        private void frmCompraVenda_Load(object sender, EventArgs e)
        {
            string Tipo = frmUsuarioPainel.transacaoTipo;
            label1.Text = Tipo;
            transacaoDT.Columns.Add("Nome Produto");
            transacaoDT.Columns.Add("Avaliacao");
            transacaoDT.Columns.Add("Quantidade");
            transacaoDT.Columns.Add("Total");


        }

        private void txtclisdispesquisar_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtpesqCV.Text;
            if (keyword == "")
            {
                txtnomeCV.Text = "";
                txtemailCV.Text = "";
                txtcontatoCV.Text = "";
                txtenderecoCV.Text = "";
                return;
            }

            CliDisBLL dc = dcDAL.PesquisarCliDisTransacao(keyword);

            txtnomeCV.Text = dc.nome;
            txtemailCV.Text = dc.email;
            txtcontatoCV.Text = dc.contato;
            txtenderecoCV.Text = dc.endereco;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtpesqDPCV.Text;
            if (keyword == "")
            {
                txtnomeDP.Text = "";
                txtinventarioDP.Text = "";
                txtavaliacaoDP.Text = "";
                txtquantidadeDP.Text = "";
                return;
            }

            produtosBLL p= pDAL.PegarProdutoTransacao(keyword);

            txtnomeDP.Text = p.nome;
            txtinventarioDP.Text = p.qti.ToString();
            txtavaliacaoDP.Text = p.avaliacao.ToString();

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string produtoNome = txtnomeDP.Text;
            decimal Avaliacao = decimal.Parse(txtavaliacaoDP.Text);
            decimal Qti = decimal.Parse(txtquantidadeDP.Text);
            decimal Total = Avaliacao * Qti;

            decimal subtotal = decimal.Parse(txtsubtotal.Text);
            subtotal = subtotal + Total;

            if(produtoNome == "")
            {
                MessageBox.Show("Selecione um produto");
            }
            else
            {
                transacaoDT.Rows.Add(produtoNome, Avaliacao, Qti, Total);
                dvgCV.DataSource = transacaoDT;

                txtsubtotal.Text = subtotal.ToString();

                txtpesqDPCV.Text = "";
                txtnomeDP.Text = "";
                txtinventarioDP.Text = "0.00";
                txtquantidadeDP.Text = "0.00";
                txtavaliacaoDP.Text = "0.00";

            }

        }

        private void txtdesconto_TextChanged(object sender, EventArgs e)
        {
            string valor = txtdesconto.Text;

            if(valor == "")
            {
                MessageBox.Show("Insira o descontro primeiro.");
            }
            else
            {
                decimal subtotal = decimal.Parse(txtsubtotal.Text);
                decimal desconto = decimal.Parse(txtdesconto.Text);

                decimal totalgeral = ((100 - desconto) / 100) * subtotal;

                txtvalortotal.Text = totalgeral.ToString();

            }

        }

        private void txtvalortotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtimposto_TextChanged(object sender, EventArgs e)
        {
            string checar = txtvalortotal.Text;

            if(checar == "")
            {
                MessageBox.Show("Insira o desconto e o valor total");
            }
            else
            {
                decimal anterior = decimal.Parse(txtvalortotal.Text);
                decimal imposto = decimal.Parse(txtimposto.Text);

                decimal totalgeralImposto = ((100 +imposto) / 100) * anterior;

                txtvalortotal.Text = totalgeralImposto.ToString();

            }

        }

        private void txttotalpago_TextChanged(object sender, EventArgs e)
        {
            decimal gvalor = decimal.Parse(txtvalortotal.Text);
            decimal valorpago = decimal.Parse(txttotalpago.Text);

            decimal valorretornado = valorpago - gvalor;

            txttroco.Text = valorretornado.ToString();

        }

        private void txttroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvarDetalhes_Click(object sender, EventArgs e)
        {
            transacaoBLL transacao = new transacaoBLL();
            transacao.tipo = label1.Text;

            String distclienteNome = txtnomeCV.Text;
            CliDisBLL dc = dcDAL.pegarDistClienteIDnome(distclienteNome);
            transacao.cli_id = dc.id;
            transacao.total_geral = Math.Round(decimal.Parse(txtvalortotal.Text),2);
            transacao.transacao_data = DateTime.Now;
            transacao.imposto = decimal.Parse(txtimposto.Text);
            transacao.desconto = decimal.Parse(txtdesconto.Text);

            transacao.transacaoDetalhes = transacaoDT;

            bool success = false;

            using(TransactionScope scope = new TransactionScope())
            {
                int transacaoID = -1;
                bool w = tDAL.Insert_transacao(transacao, out transacaoID);
                for (int i = 0; 1 < transacaoDT.Rows.Count; i++)
                {
                    transacaodetalhesBLL transacaodetalhes = new transacaodetalhesBLL();
                    string produtoNome = transacaoDT.Rows[i][0].ToString();
                    produtosBLL p = pDAL.PegarProdutoIDnome(produtoNome);

                    transacaodetalhes.produto_id = p.id;
                    transacaodetalhes.avaliacao = decimal.Parse(transacaoDT.Rows[i][1].ToString());
                    transacaodetalhes.qti = decimal.Parse(transacaoDT.Rows[i][2].ToString());
                    transacaodetalhes.total = Math.Round(decimal.Parse(transacaoDT.Rows[i][3].ToString()), 2);

                    transacaodetalhes.cli_id = dc.id;
                    transacaodetalhes.add_data = DateTime.Now;



                    string transacaoTipo = label1.Text;

                    bool x = false;
                    if (transacaoTipo == "Compra")
                    {
                        x = pDAL.IncProduto(transacaodetalhes.produto_id, transacaodetalhes.qti);
                    }
                    else if (transacaoTipo == "Vendas")
                    {
                        x = pDAL.DescProduto(transacaodetalhes.produto_id, transacaodetalhes.qti);
                    }



                    bool y = tdDAL.Insert_TransacaoDetalhe(transacaodetalhes);
                    success = w && y;


                }
                if(success == true)
                {
                    scope.Complete();

                    DGVPrinter printer = new DGVPrinter();

                    printer.Title = "\r\n\r\n SISTEMA DE VENDAS";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader= false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Disconto" + txtdesconto.Text + "%\r\n" + "Imposto" + txtimposto.Text + "%\r\n" + "Valor Total" + txtvalortotal.Text + "\r\n" + "";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dvgCV);










                    MessageBox.Show("Dados salvos com sucesso");
                    dvgCV.DataSource = null;
                    dvgCV.Rows.Clear();

                    txtpesqCV.Text = "";
                    txtpesqDPCV.Text = "";
                    txtnomeCV.Text = "";
                    txtnomeDP.Text = "";
                    txtemailCV.Text = "";
                    txtcontatoCV.Text = "";
                    txtenderecoCV.Text = "";
                    txtinventarioDP.Text = "0";
                    txtavaliacaoDP.Text = "0";
                    txtsubtotal.Text = "0";
                    txtdesconto.Text = "0";
                    txtimposto.Text = "0";
                    txtvalortotal.Text = "0";
                    txttotalpago.Text = "0";
                    txttroco.Text = "0";

                }
                else
                {
                    MessageBox.Show("nao foi possivel");
                }

            }

        }
    }
}

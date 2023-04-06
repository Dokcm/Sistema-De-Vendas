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
using System.Windows.Forms;

namespace SistemaVendas.UI
{
    public partial class frmprodutos : Form
    {
        public frmprodutos()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        categoirasDAL cdal = new categoirasDAL();
        produtosBLL p = new produtosBLL();
        produtosDAL pdal = new produtosDAL();
        private void frmprodutos_Load(object sender, EventArgs e)
        {
            DataTable categoriasDT = cdal.Select();
            cmbcategoria.DataSource= categoriasDT;
            cmbcategoria.DisplayMember = "titulo";
            cmbcategoria.ValueMember = "Titulo";

            DataTable dt = pdal.Select();
            dvgprodutos.DataSource = dt;

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            p.nome = txtprodnome.Text;
            p.categoria = cmbcategoria.Text;
            p.descricao = txtproddescricao.Text;
            p.avaliacao = decimal.Parse(txtprodavaliacao.Text);
            p.qti = 0;
            p.add_data = DateTime.Now;

            bool isSucesso = pdal.Insert(p);
            if (isSucesso == true)
            {
                MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO");
                Limpar();
                DataTable dt = pdal.Select();
                dvgprodutos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL REALIZAR O CADASTRO DO PRODUTO");
            }
        } 
        public void Limpar()
        {
            txtprodid.Text = "";
            txtprodnome.Text = "";
            txtproddescricao.Text = "";
            txtprodavaliacao.Text = "";
            txtprodpesquisar.Text = "";
        }

        private void dvgcategorias_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtprodid.Text = dvgprodutos.Rows[rowIndex].Cells[0].Value.ToString();
            txtprodnome.Text = dvgprodutos.Rows[rowIndex].Cells[1].Value.ToString();
            cmbcategoria.Text = dvgprodutos.Rows[rowIndex].Cells[2].Value.ToString();
            txtproddescricao.Text = dvgprodutos.Rows[rowIndex].Cells[3].Value.ToString();
            txtprodavaliacao.Text = dvgprodutos.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtprodid.Text);
            p.nome = txtprodnome.Text;
            p.categoria = cmbcategoria.Text;
            p.descricao = txtproddescricao.Text;
            p.avaliacao = decimal.Parse(txtproddescricao.Text);
            p.add_data = DateTime.Now;

            bool isSucesso = pdal.Update(p);

            if (isSucesso == true)
            {
                MessageBox.Show("PRODUTO ATUALIZADO COM SUCESSO");
                Limpar();
                DataTable dt = pdal.Select();
                dvgprodutos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL ATUALIZAR ESTE PRODUTO");
            }

        }
        private void btndeletar_Click_1(object sender, EventArgs e)
        {
            p.id = int.Parse(txtprodid.Text);

            bool isSucesso = pdal.Delete(p);

            if (isSucesso == true)
            {
                MessageBox.Show("CADASTRO DELETADO COM SUCESSO");
                Limpar();
                DataTable dt = pdal.Select();
                dvgprodutos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL DELETAR ESTE CADASTRO");
            }

        }

        private void txtprodpesquisar_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtprodpesquisar.Text;

            if (keywords != null)
            {
                DataTable dt = pdal.Pesquisar(keywords);
                dvgprodutos.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Pesquisar(keywords);
                dvgprodutos.DataSource = dt;
            }
        }
    }
}

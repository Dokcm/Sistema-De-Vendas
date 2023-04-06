using SistemaVendas.BLL;
using SistemaVendas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.UI
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        categoriasBLL c = new categoriasBLL();
        categoirasDAL dal = new categoirasDAL();
        userDAL udal = new userDAL();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click_1(object sender, EventArgs e)
        {
            c.titulo = txtcattitulo.Text;
            c.descricao = txtcatdescricao.Text;
            c.add_data = DateTime.Now;

            bool success = dal.Insert(c);

            if (success == true)
            {
                MessageBox.Show("CATEGORIA CADASTRADA COM SUCESSO");

                Limpar();

                DataTable dt = dal.Select();
                dvgcategorias.DataSource = dt;

            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL CADASTRAR ESTA CATEGORIA");
            }

        }      
        public void Limpar()
        {
            txtcattitulo.Text = "";
            txtcatid.Text = "";
            txtcatdescricao.Text = "";
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dvgcategorias.DataSource = dt;
        }

        private void dvgusuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtcatid.Text = dvgcategorias.Rows[rowIndex].Cells[0].Value.ToString();
            txtcattitulo.Text = dvgcategorias.Rows[rowIndex].Cells[1].Value.ToString();
            txtcatdescricao.Text = dvgcategorias.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btnatualizar_Click_1(object sender, EventArgs e)
        {
            c.id = int.Parse(txtcatid.Text);

            c.titulo = txtcattitulo.Text;
            c.descricao = txtcatdescricao.Text;
            c.add_data = DateTime.Now;
            
            bool isSucesso = dal.Update(c);

            if (isSucesso == true)
            {
                MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO");
                Limpar();
                DataTable dt = dal.Select();
                dvgcategorias.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL ATUALIZAR ESTE CADASTRO");
            }
        }

        private void btndeletar_Click_1(object sender, EventArgs e)
        {
            c.id = int.Parse(txtcatid.Text);

            bool isSucesso = dal.Delete(c);

            if (isSucesso == true)
            {
                MessageBox.Show("Cadastro deletado com sucesso");
                Limpar();
                DataTable dt = dal.Select();
                dvgcategorias.DataSource = dt;
            }
            else
            {
                MessageBox.Show("nao foi possivel deltar este cadastro");
            }

        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {

            string keywords = txtpesquisar.Text;

            if(keywords != null)
            {
                DataTable dt = dal.Pesquisar(keywords);
                dvgcategorias.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Pesquisar(keywords);
                dvgcategorias.DataSource = dt;
            }

        }

        private void dvgcategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

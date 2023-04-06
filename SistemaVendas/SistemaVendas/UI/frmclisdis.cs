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
    public partial class frmclisdis : Form
    {
        public frmclisdis()
        {
            InitializeComponent();
        }
        userDAL udal = new userDAL();
        CliDisDAL dcDal = new CliDisDAL();
        CliDisBLL dc = new CliDisBLL();

        private void frmclisdis_Load(object sender, EventArgs e)
        {
            DataTable dt = dcDal.Select();
            dvgclisdisusuarios.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            dc.tipo = cmbclisdistipo.Text;
            dc.nome = txtclisdisnome.Text;
            dc.email = txtclisdisemail.Text;
            dc.contato = txtclisdiscontato.Text;
            dc.endereco = txtclisdisendereco.Text;
            dc.add_data = DateTime.Now;

            bool success = dcDal.Insert(dc);

            if (success == true)
            {
                MessageBox.Show("Usuario/Distribuidora CADASTRADA COM SUCESSO");

                Limpar();

                DataTable dt = dcDal.Select();
                dvgclisdisusuarios.DataSource = dt;

            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL CADASTRAR o Usuario/Distribuidora");
            }
        }

        public void Limpar()
        {
            cmbclisdistipo.Text = "";
            txtclisdisnome.Text = "";
            txtclisdisemail.Text = "";
            txtclisdiscontato.Text = "";
            txtclisdisendereco.Text = "";
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtclidisid.Text);
            dc.tipo = cmbclisdistipo.Text;
            dc.nome = txtclisdisnome.Text;
            dc.email = txtclisdisemail.Text;
            dc.contato = txtclisdiscontato.Text;
            dc.endereco = txtclisdisendereco.Text;
            dc.add_data = DateTime.Now;

            bool isSucesso = dcDal.Update(dc);

            if (isSucesso == true)
            {
                MessageBox.Show("Usuario/Distribuidora ATUALIZADO COM SUCESSO");
                Limpar();
                DataTable dt = dcDal.Select();
                dvgclisdisusuarios.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL ATUALIZAR ESTE Usuario/Distribuidora ");
            }
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtclidisid.Text);

            bool isSucesso = dcDal.Delete(dc);

            if (isSucesso == true)
            {
                MessageBox.Show("Usuario/Distribuidora  deletado com sucesso");
                Limpar();
                DataTable dt = dcDal.Select();
                dvgclisdisusuarios.DataSource = dt;
            }
            else
            {
                MessageBox.Show("nao foi possivel deltar este Usuario/Distribuidora ");
            }
        }

        private void txtclisdispesquisar_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtclisdispesquisar.Text;

            if (keywords != null)
            {
                DataTable dt = dcDal.Pesquisar(keywords);
                dvgclisdisusuarios.DataSource = dt;
            }
            else
            {
                DataTable dt = dcDal.Pesquisar(keywords);
                dvgclisdisusuarios.DataSource = dt;
            }
        }

        private void dvgclisdisusuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            cmbclisdistipo.Text = dvgclisdisusuarios.Rows[rowIndex].Cells[0].Value.ToString();
            txtclisdisnome.Text = dvgclisdisusuarios.Rows[rowIndex].Cells[1].Value.ToString();
            txtclisdisemail.Text = dvgclisdisusuarios.Rows[rowIndex].Cells[2].Value.ToString();
            txtclisdiscontato.Text = dvgclisdisusuarios.Rows[rowIndex].Cells[3].Value.ToString();
            txtclisdisendereco.Text = dvgclisdisusuarios.Rows[rowIndex].Cells[4].Value.ToString();
            txtclidisid.Text = dvgclisdisusuarios.Rows[rowIndex].Cells[4].Value.ToString();
        }
    }
}

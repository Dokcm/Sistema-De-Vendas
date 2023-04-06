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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            u.nome = txtnome.Text;
            u.s_nome = txts_nome.Text;
            u.email = txtemail.Text;
            u.usuario = txtusuario.Text;
            u.senha = txtsenha.Text;
            u.contato = txtcontato.Text;
            u.endereco = txtendereco.Text;
            u.sexo = cmbsexo.Text;
            u.usuario_tipo = cmbtipousuario.Text;
            u.add_data = DateTime.Now;
            u.add_por = 1;

            bool isSucesso = dal.Insert(u);
            if (isSucesso == true)
            {
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL REALIZAR ESTE CADASTRO");
            }
            DataTable dt = dal.Select();
            dvgusuarios.DataSource = dt;

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dvgusuarios.DataSource = dt;

        }
        private void Limpar()
        {
            txtid.Text = "";
            txtnome.Text ="";
            txts_nome.Text ="";
            txtemail.Text = "";
            txtusuario.Text = "";
            txtsenha.Text = "";
            txtcontato.Text = "";
            txtendereco.Text = "";
            cmbsexo.Text = "";
            cmbtipousuario.Text = "";
           
        }

        private void dvgusuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtid.Text = dvgusuarios.Rows[rowIndex].Cells[0].Value.ToString();
            txtnome.Text = dvgusuarios.Rows[rowIndex].Cells[1].Value.ToString();
            txts_nome.Text = dvgusuarios.Rows[rowIndex].Cells[2].Value.ToString();
            txtemail.Text = dvgusuarios.Rows[rowIndex].Cells[3].Value.ToString();
            txtusuario.Text = dvgusuarios.Rows[rowIndex].Cells[4].Value.ToString();
            txtsenha.Text = dvgusuarios.Rows[rowIndex].Cells[5].Value.ToString();
            txtcontato.Text = dvgusuarios.Rows[rowIndex].Cells[6].Value.ToString();
            txtendereco.Text = dvgusuarios.Rows[rowIndex].Cells[7].Value.ToString();
            cmbsexo.Text = dvgusuarios.Rows[rowIndex].Cells[8].Value.ToString();
            cmbtipousuario.Text = dvgusuarios.Rows[rowIndex].Cells[9].Value.ToString();

        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {

            u.id = Convert.ToInt32(txtid.Text);

            u.nome = txtnome.Text;
            u.s_nome = txts_nome.Text;
            u.email = txtusuario.Text;
            u.usuario = txtusuario.Text;
            u.senha = txtsenha.Text;
            u.contato = txtcontato.Text;
            u.endereco = txtendereco.Text;
            u.sexo = cmbsexo.Text;
            u.usuario_tipo = cmbtipousuario.Text;
            u.add_data = DateTime.Now;
            u.add_por = 1;

            bool isSucesso = dal.Update(u);

            if (isSucesso == true)
            {
                MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL ATUALIZAR ESTE CADASTRO");
            }
            DataTable dt = dal.Select();
            dvgusuarios.DataSource = dt;

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtid.Text);

            bool isSucesso = dal.Delete(u);

            if (isSucesso == true )
            {
                MessageBox.Show("CADASTRO DELETADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL DELETAR ESTE CADASTRO");
            }
            DataTable dt = dal.Select();
            dvgusuarios.DataSource = dt;


        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

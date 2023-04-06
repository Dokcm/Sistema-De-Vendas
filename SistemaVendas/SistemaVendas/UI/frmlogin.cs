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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        LoginBLL l = new LoginBLL();
        LoginDAL dal = new LoginDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            l.nome = txtusuario.Text.Trim();
            l.senha = txtsenha.Text.Trim();
            l.usuario_tipo = cmbusuariotipo.Text.Trim();

            bool success = dal.loginChecar(l);
            if(success == true)
            {
                MessageBox.Show("Login com sucesso");

                switch(l.usuario_tipo)
                {
                    case "Administrador":
                        {
                            frmPainelAdmin admin = new frmPainelAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "Usuario":
                        {
                            frmUsuarioPainel User = new frmUsuarioPainel();
                            User.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("login e senha incorretas");
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("Nao foi possivel entrar");
            }
        }
    }
}

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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoirasDAL cdal = new categoirasDAL();
        produtosDAL pdal = new produtosDAL();

        private void frmInventario_Load(object sender, EventArgs e)
        {
            DataTable cDt = cdal.Select();
            cmbiventario.DataSource = cDt;

            cmbiventario.DisplayMember = "Titulo";
            cmbiventario.ValueMember = "Titulo";

            DataTable pDt = pdal.Select();
            dvgiventario.DataSource = pDt;

        }

        private void cmbiventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = cmbiventario.Text;
            
            DataTable dt = pdal.MostrarProdutoPorCat(categoria);

            dvgiventario.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dvgiventario.DataSource = dt;
        }
    }
}

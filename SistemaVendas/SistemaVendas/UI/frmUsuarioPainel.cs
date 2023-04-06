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
    public partial class frmUsuarioPainel : Form
    {
        public frmUsuarioPainel()
        {
            InitializeComponent();
        }

        public static string transacaoTipo;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmclisdis clidis = new frmclisdis();
            clidis.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transacaoTipo = "Compras";
            frmCompraVenda compra = new frmCompraVenda();
            compra.Show();

        }

        private void frmUsuarioPainel_Load(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transacaoTipo = "Vendas";
            frmCompraVenda Vendas = new frmCompraVenda();
            Vendas.Show();

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
        }
    }
}

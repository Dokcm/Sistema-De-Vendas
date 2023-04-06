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
    public partial class frmPainelAdmin : Form
    {
        public frmPainelAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios user = new frmUsuarios();
            user.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias categoria = new frmCategorias();
            categoria.Show();;
        }

        private void frmPainelAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmprodutos produtos = new frmprodutos();
            produtos.Show();
        }

        private void clientesDistribuidorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmclisdis clidis = new frmclisdis();
            clidis.Show();
        }

        private void transaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtransacao transacao = new frmtransacao();
            transacao.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
        }
    }
}

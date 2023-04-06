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
    public partial class frmtransacao : Form
    {
        public frmtransacao()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        transacaoDAL tdal = new transacaoDAL();
        private void frmtransacao_Load(object sender, EventArgs e)
        {
            DataTable dt = tdal.MostrarTransacao();
            dvgtransacao.DataSource = dt;
        }

        private void cmbtransacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbtransacao.Text;
            DataTable dt = tdal.MostrarTransacaoPeloTipo(tipo);
            dvgtransacao.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = tdal.MostrarTransacao();
            dvgtransacao.DataSource= dt;
        }
    }
}

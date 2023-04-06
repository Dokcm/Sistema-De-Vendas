using SistemaVendas.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.DAL
{
    internal class transacaodetalhesDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool Insert_TransacaoDetalhe(transacaodetalhesBLL td)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "INSERT INTO tbl_transacao(produto_id,avaliacao,qti,total,cli_id,add_data,add_por) VALUES (produto_id,avaliacao,qti,total,cli_id,add_data,add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@produto_id", td.produto_id) ;
                cmd.Parameters.AddWithValue("@avaliacao", td.avaliacao);
                cmd.Parameters.AddWithValue("@qti", td.qti);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@cli_id", td.cli_id);
                cmd.Parameters.AddWithValue("@add_data", td.add_data);
                cmd.Parameters.AddWithValue("@add_por", td.add_por);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {

                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucess;

        }
    }
}

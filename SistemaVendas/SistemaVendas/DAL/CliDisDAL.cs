using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVendas.BLL;

namespace SistemaVendas.DAL
{
    internal class CliDisDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM tbl_clientes";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        public bool Insert(CliDisBLL dc)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "INSERT INTO tbl_clientes(tipo,nome,email,contato,endereco,add_data,add_por) VALUES (@tipo,@nome,@email,@contato,@endereco,@add_data,@add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tipo", dc.tipo);
                cmd.Parameters.AddWithValue("@nome", dc.nome);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contato", dc.contato);
                cmd.Parameters.AddWithValue("@endereco", dc.endereco);
                cmd.Parameters.AddWithValue("@add_data", dc.add_data);
                cmd.Parameters.AddWithValue("@add_por", dc.add_por);

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

        public bool Update(CliDisBLL dc)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_clientes SET tipo=@tipo,nome=@nome,email=@email,contato=@contato,endereco=@endereco,add_data=@add_data,add_por=@add_por WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tipo", dc.tipo);
                cmd.Parameters.AddWithValue("@nome", dc.nome);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contato", dc.contato);
                cmd.Parameters.AddWithValue("@endereco", dc.endereco);
                cmd.Parameters.AddWithValue("@add_data", dc.add_data);
                cmd.Parameters.AddWithValue("@add_por", dc.add_por);
                cmd.Parameters.AddWithValue("@id", dc.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
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
            return isSucesso;
        }

        public bool Delete(CliDisBLL dc)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM tbl_clientes WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", dc.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
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
            return isSucesso;

        }

        public DataTable Pesquisar(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_clientes WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%' or contato LIKE '%" + keywords + "%' or tipo LIKE '%" + keywords + "%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        public CliDisBLL PesquisarCliDisTransacao(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            CliDisBLL dc = new CliDisBLL();
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select nome,email,contato,endereco from tbl_clientes WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dc.nome = dt.Rows[0]["nome"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contato = dt.Rows[0]["contato"].ToString();
                    dc.endereco = dt.Rows[0]["endereco"].ToString();
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
            return dc;

        }

        public CliDisBLL pegarDistClienteIDnome(string Nome)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            CliDisBLL dc = new CliDisBLL();
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select id from tbl_clientes WHERE nome= '"+Nome+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());

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
            return dc;
        }
    }
}

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
    class produtosDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM tbl_produtos";
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
        public bool Insert(produtosBLL p)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "INSERT INTO tbl_produtos(nome,categoria,descricao,avaliacao,qti,add_data,add_por) VALUES (@nome,@categoria,@descricao,@avaliacao,@qti,@add_data,@add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@categoria", p.categoria);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@avaliacao", p.avaliacao);
                cmd.Parameters.AddWithValue("@qti", p.qti);
                cmd.Parameters.AddWithValue("@add_data", p.add_data);
                cmd.Parameters.AddWithValue("@add_por", p.add_por);

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

        public bool Update(produtosBLL p)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_produtos SET nome=@nome,categoria=@categoria,descricao=@descricao,avaliacao=@avaliacao,qti=@qti,add_data=@add_data,add_por=@add_por WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@categoria", p.categoria);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@avaliacao", p.avaliacao);
                cmd.Parameters.AddWithValue("@qti", p.qti);
                cmd.Parameters.AddWithValue("@add_data", p.add_data);
                cmd.Parameters.AddWithValue("@add_por", p.add_por);
                cmd.Parameters.AddWithValue("@id", p.id);

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

        public bool Delete(produtosBLL p)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM tbl_produtos WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", p.id);

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
                String sql = "Select * from tbl_produtos WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%' or descricao LIKE '%" + keywords + "%' or categoria LIKE '%" + keywords + "%' ";
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
        
        public produtosBLL PegarProdutoTransacao(string keywords)
        {
            produtosBLL p = new produtosBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select nome,avaliacao,qti from tbl_produtos WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    p.nome = dt.Rows[0]["nome"].ToString();
                    p.avaliacao = decimal.Parse(dt.Rows[0]["avaliacao"].ToString());
                    p.qti = decimal.Parse(dt.Rows[0]["qti"].ToString());
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
            return p;

        }

        public produtosBLL PegarProdutoIDnome(string produtoNome)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            produtosBLL p = new produtosBLL();
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select id from tbl_produtos WHERE nome='" + produtoNome + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
                }         
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return p;
       
        }

        public decimal GetProdutoQty(int produtoID)

        {
            SqlConnection conn = new SqlConnection(myconnstring);

            decimal qti = 0;
            DataTable dt = new DataTable();

            try
            {
                String sql = "Select qti FROM tbl_produtos WHERE id=" + produtoID;
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
                
                if(dt.Rows.Count > 0 )
                {
                    qti = decimal.Parse(dt.Rows[0]["qti"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                conn.Close(); 
            }
            return qti;
        }
        
        public bool IncProduto(int ProdutoID, decimal IncQty) 
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                decimal correntQty = GetProdutoQty(ProdutoID);
                decimal NovaQty = correntQty + IncQty;

                success = UpdateQuantidade(ProdutoID, NovaQty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;


        }

        private bool UpdateQuantidade(int produtoID, decimal Qty)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "Update tbl_produtos set qti=@qti WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@qti", Qty);
                cmd.Parameters.AddWithValue("@id", produtoID);

                SqlDataAdapter adapter = new SqlDataAdapter();

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0) 
                {
                    success=true;
                }
                else
                {
                    success = false;
                }
            
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                conn.Close(); 
            }
            return success;
        }

        public bool DescProduto(int ProdutoID, decimal Qty)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                decimal correnteQty = GetProdutoQty(ProdutoID);
                decimal NovaQty = correnteQty - Qty;

                success = UpdateQuantidade(ProdutoID, NovaQty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        
        }

        public DataTable MostrarProdutoPorCat(string categoria)
        {
            
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                String sql = "Select * from tbl_produtos where categoria='" + categoria + "'";
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

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheGildedRoseOnlineStore
{
    public partial class productLists : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = "Server=ANNANJITH;Database = GildedRose_Online; Integrated Security=True; ";
                SqlConnection conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [ProductDetails] WHERE productQuantiy >= 1", conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    int id = 0;

                    //foreach (DataRow dr in dtbl.Rows)
                    //{
                    //    id = Convert.ToInt32(dr[3]);                        
                    //}                    
                    rptProducts.DataSource = dtbl;
                    rptProducts.DataBind();

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }

        }
        static byte[] GetImageData(int id)
        {
            string connectionString = "Server=ANNANJITH;Database = GildedRose_Online; Integrated Security=True; ";
            string sql = "SELECT [productImage] FROM [ProductDetails] WHERE id = @id;";

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, connection))
            {
                System.Data.SqlClient.SqlParameter parameter = new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int);
                parameter.Value = id;
                command.Parameters.Add(parameter);

                connection.Open();
                object value = command.ExecuteScalar();
                connection.Close();

                if (value != null)
                {
                    return (byte[])value;
                }
            }

            return null;
        }

        static System.Drawing.Image GetImage(int id)
        {
            System.Drawing.Image image = null;

            byte[] data = GetImageData(id);

            if (data != null)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    ms.Write(data, 0, data.Length);
                    ms.Position = 0L;

                    image = new Bitmap(ms);
                }
            }

            return image;
        }

        protected void btnBuyNow_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=ANNANJITH;Database = GildedRose_Online; Integrated Security=True; ";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("UPDATE [ProductDetails] SET productQuantiy = (productQuantiy - 1) WHERE  id = ", conn);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void rptProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Buy")
            {
                string id = Convert.ToString(e.CommandArgument);
                string connectionString = "Server=ANNANJITH;Database = GildedRose_Online; Integrated Security=True; ";
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE [ProductDetails] SET productQuantiy = (productQuantiy - 1) WHERE  id = @id");
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("Checkout.aspx");
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
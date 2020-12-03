using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheGildedRoseOnlineStore
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=ANNANJITH;Database = GildedRose_Online; Integrated Security=True; ";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [CheckoutDetails] ([Name], [Email], [Phone], [Address]) VALUES (@Name, @Email, @Phone, @Address)");
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.ExecuteNonQuery();
                Response.Redirect("OrderPlaced.aspx");
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
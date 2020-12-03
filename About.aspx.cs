using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheGildedRoseOnlineStore
{
    public partial class About : Page
    {
        public string connectionString = "data source=localhost;initial catalog = northwind; persist security info = True;Integrated Security = SSPI; providerName = System.Data.SqlClient";
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=ANNANJITH;Database = GildedRose_Online; Integrated Security=True; ";
            SqlConnection conn = new SqlConnection(connectionString);
            string name = txtFullName.Text;
            string email = txtEmail.Text;
            string password = " ";
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                password = txtPassword.Text;
            }

            try
            {
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [UserDetails] WHERE [Email] = '" + email + "'", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                foreach (DataRow dr in dtbl.Rows)
                {
                    if (dr[2].ToString() == email)
                    {
                        lblNotice.Text = "You already have an account with Us, Please log-in";
                        lblNotice.Visible = true;
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO [UserDetails] ([Name], [Email], [Password]) VALUES (@Name, @Email, @Password)");
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.ExecuteNonQuery();
                        lblNotice.Text = "Account created Sucessfully, Please log-in";
                        lblNotice.Visible = true;
                    }
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=ANNANJITH;Database = GildedRose_Online; Integrated Security=True; ";
            SqlConnection conn = new SqlConnection(connectionString);
            string loginEmail = txtLoginEmail.Text;
            string loginPswd = txtLoginPassword.Text;
            try
            {
                conn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [UserDetails] WHERE [Email] = '" + loginEmail + "'", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                foreach (DataRow dr in dtbl.Rows)
                {
                    if (dr[2].ToString() == loginEmail && dr[3].ToString() == loginPswd)
                    {
                        Response.Redirect("productLists.aspx");
                    }
                    else
                    {
                        lblNotice.Text = "Account doesn't exist, Please create an account. ";
                        lblNotice.Visible = true;
                    }
                }


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
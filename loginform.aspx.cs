using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace hallbooking
{
    public partial class loginform : System.Web.UI.Page
    {
        public string ukey;

        private readonly object msg;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginform.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ToString());
            try
            {
                string username = TextBox1.Text;
                string password = TextBox2.Text;
                string account_type = DropDownList1.SelectedItem.Value;
                con.Open();


                if (account_type == "user")
                {
                    string qry = "select * from users where username='" + username + "' and password='" + password + "' and account_type='" + account_type + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ToString());
                        con2.Open();
                        string qry2 = "select ukey from users where username='" + username + "'";
                        SqlCommand cmd2 = new SqlCommand(qry2, con2);
                        ukey = Convert.ToString(cmd2.ExecuteScalar());

                        Response.Redirect("loginform.aspx?ukey=" + ukey);
                        con2.Close();
                    }
                    else
                    {
                        msg.Text = "Wrong Credentials";
                    }
                }
                else if (account_type == "admin")
                {
                    string qry = "select * from users where username='" + username + "' and password='" + password + "' and account_type='" + account_type + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ToString());
                        con2.Open();
                        string qry2 = "select ukey from users where username='" + username + "'";
                        SqlCommand cmd2 = new SqlCommand(qry2, con2);
                        ukey = Convert.ToString(cmd2.ExecuteScalar());

                        Response.Redirect("loginform.aspx?ukey=" + ukey);
                        con2.Close();
                    }
                    else
                    {
                        msg.Text = "Wrong Credentials";
                    }
                }
                else if (account_type == "Developer")
                {
                    string qry = "select * from users where username='" + username + "' and password='" + password + "' and account_type='" + account_type + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString1"].ToString());
                        con2.Open();
                        string qry2 = "select ukey from users where username='" + username + "'";
                        SqlCommand cmd2 = new SqlCommand(qry2, con2);
                        ukey = Convert.ToString(cmd2.ExecuteScalar());

                        Response.Redirect("loginform.aspx?ukey=" + ukey);
                        con2.Close();
                    }
                    else
                    {
                        msg.Text = "Wrong Credentials";
                    }
                }
                else
                {
                    msg.Text = "Wrong Credentials";

                }
                con.Close();
            }

            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}
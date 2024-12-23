using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_logic
{
    public partial class login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog =ado;integrated security=true";
        public login()
        {
            InitializeComponent();
        }

        private void lnkLogInBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogInUserName.Text=="Admin" && txtLogInPassword.Text=="ADMIN123")
                {
                    Admin a = new Admin();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    try
                    {
                        con = new SqlConnection(s);
                        con.Open();
                        cmd = new SqlCommand("select * from registration  where username=@username and password=@password and status='ACTIVATED' ", con);
                        cmd.Parameters.AddWithValue("@username",txtLogInUserName.Text);
                        cmd.Parameters.AddWithValue("@password",txtLogInPassword.Text);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            userlogin u = new  userlogin();
                            u.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
    }
}

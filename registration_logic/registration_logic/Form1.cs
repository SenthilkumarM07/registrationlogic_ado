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
    public partial class Register : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog =ado;integrated security=true";
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(txtRegUserName.Text)&&string.IsNullOrEmpty(txtRegMailId.Text)&&string.IsNullOrEmpty(txtRegPassword.Text))
            {
                MessageBox.Show("please enter all details");   
            }
            else
            {
                try           
                {
                con= new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("insert_reg", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username",txtRegUserName.Text);
                cmd.Parameters.AddWithValue("@mailid", txtRegMailId.Text);
                cmd.Parameters.AddWithValue("@password", txtRegPassword.Text);
                int res = cmd.ExecuteNonQuery();
                    if (res >= 1)
                    {
                        MessageBox.Show("inserted SuccessFully");
                   
                    }
                    else
                    {
                        MessageBox.Show("Not inserted ");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    con.Close();
                }
            }
        }

        

        private void lnkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnRegNext_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }
    }
}

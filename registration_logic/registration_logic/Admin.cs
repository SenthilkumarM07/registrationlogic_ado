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
    public partial class Admin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        DataSet ds;

        string s = "server=DESKTOP-QGETDS4\\SQLEXPRESS;initial catalog =ado;integrated security=true";
        public Admin()
        {
            InitializeComponent();
        }

        private void lnkAdminBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(s);
                con.Open();
                da = new SqlDataAdapter(" select * from registration",con);
                dt = new DataTable();
                da.Fill(dt);
                dgvAdmin.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(s);
                con.Open();
                cmd = new SqlCommand("update_reg",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtAdminUserName.Text);
                int res=cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("ACTIVATED SUCESSFULLY");
                }
                else
                {
                    MessageBox.Show("NOT ACTIVATED");
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
}

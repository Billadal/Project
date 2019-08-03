using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FruitsProject
{
    public partial class Registration : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        

        
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtusername.Text==" " || txtpassword.Text==" ")
                {
                    MessageBox.Show("Enter Username and Password");
                }

                cmd = new SqlCommand("select * from Registration where name='" + txtusername.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if(i>0)
                {
                    MessageBox.Show("Username" + txtusername.Text + "already exists");
                }
                else
                {
                    cmd = new SqlCommand("insert into Registration(name, password,address,contact,email) values" +
                        "('" + txtusername.Text + "','" + txtpassword.Text + "',,'" + txtaddress.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New User Registered Successfully");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";
        }
    }
}

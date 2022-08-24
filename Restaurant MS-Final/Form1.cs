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

namespace Restaurant_MS_Final
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Registation us = new Registation();
            us.Show();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {        
            DialogResult dr;
            dr= MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUsername.Text == "Admin1" && txtPassword.Text == "Admin1")
                {
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                }                            
            }
            else
            {               
                query = "select * from users where username = '" + txtUsername.Text + "' or email = '" + txtUsername.Text + "' and pass ='" + txtPassword.Text + "' ";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    string role = ds.Tables[0].Rows[0][2].ToString();
                    if (role == "Administrator")
                    {
                        Administrator admin = new Administrator(txtUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Restaurant")
                    {
                        Restaurant1 restaurant1 = new Restaurant1();
                        restaurant1.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Form formBackground = new Form();

            try
            {
                using (sendCode sc = new sendCode())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    sc.Owner = formBackground;
                    sc.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            cbShowPass.Visible = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            cbShowPass.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registation rr = new Registation();
            rr.Show();
            this.Hide();
        }
    }

    class Restaurant
    {
    }
}

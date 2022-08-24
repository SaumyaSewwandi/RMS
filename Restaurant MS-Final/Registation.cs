using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_MS_Final
{
    public partial class Registation : Form
    {
        function fn = new function();
        String query;

        public Registation()
        {
            InitializeComponent();
        }     

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        public void clearAll()
        {
            txtUserID.Clear();
            txtName.Clear();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            query = "select * from users where username ='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox2.ImageLocation = @"C:\Users\Thilini Chamika\source\repos\Restaurant MS-Final\image\check-mark.png";
            }
            else
            {
                pictureBox2.ImageLocation = @"C:\Users\Thilini Chamika\source\repos\Restaurant MS-Final\image\error.png";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String uid = txtUserID.Text;
            String role = txtUserRole.Text;
            String name = txtName.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

            try
            {
                query = "insert into users(userID,userRole,name,mobile,email,username,pass) values('"+uid+"','" + role + "','" + name + "','" + mobile + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Sign Up Successful");

            }
            catch (Exception)
            {
                MessageBox.Show("Username Allready Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where userID ='" + txtUserID.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                
            }
            else
            {
                MessageBox.Show("User ID Allready Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registation_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_MS_Final.AdministratorUC
{
    public partial class UC_A_AddUser : UserControl
    {
        function fn = new function();
        String query;

        public UC_A_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
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
                query = "insert into users(userID,userRole,name,mobile,email,username,pass) values('"+uid+"','" +role+ "','" +name+ "'," +mobile+ ",'" + email + "','" +username+ "','" +pass+ "')";
                fn.setData(query, "Sign Up Successful");

            }
            catch (Exception)
            {
                MessageBox.Show("Username Allready Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtUserID.Clear();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username ='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"D:\My Projects\Restaurant MS-Final\image\check-mark.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"D:\My Projects\Restaurant MS-Final\Image\error.png";
            }
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
                MessageBox.Show("UserID Allready Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

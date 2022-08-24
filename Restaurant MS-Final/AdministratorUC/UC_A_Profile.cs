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
    public partial class UC_A_Profile : UserControl
    {
        function fn = new function();
        string query;

        public UC_A_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { userNameLabel.Text = value; }
        }

        private void UC_A_Profile_Enter(object sender, EventArgs e)
        {
            query = "select*from users where username ='" + userNameLabel.Text + "' or email='" + userNameLabel.Text + "' ";
            DataSet ds = fn.getData(query);
            txtUserID.Text=ds.Tables[0].Rows[0][1].ToString();
            txtUserRole.Text = ds.Tables[0].Rows[0][2].ToString();
            txtName.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_A_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String uid = txtUserID.Text;
            String role = txtUserRole.Text;
            String name = txtName.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String username = userNameLabel.Text;
            string pass = txtPassword.Text;

            query = "update users set userID='"+uid+"' userRole='" + role + "',name='" + name + "',mobile=" + mobile + ",email='" + email + "',pass='" + pass + "'where username='" + username + "' ";
            fn.setData(query, "Profile Updation Successful.");
        }
    }
}

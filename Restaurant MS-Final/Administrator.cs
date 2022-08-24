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
    public partial class Administrator : Form
    {
        string user = "";

        public Administrator()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public Administrator(string username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            uC_A_ViewUser1.ID = ID;
            uC_A_Profile1.ID = ID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_A_AddUser1.Visible = true;
            uC_A_AddUser1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_A_Dashboard1.Visible = true;
            uC_A_Dashboard1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_A_Profile1.Visible = true;
            uC_A_Profile1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_A_ViewUser1.Visible = true;
            uC_A_ViewUser1.BringToFront();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_A_Dashboard1.Visible = false;
            uC_A_AddUser1.Visible = false;
            uC_A_ViewUser1.Visible = false;
            uC_A_Profile1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void uC_A_Profile1_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Restaurant1 restaurant1 = new Restaurant1();
            restaurant1.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            uC_CustomerInfo1.Visible = true;
            uC_CustomerInfo1.BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uC_C_Reservation1.Visible = true;
            uC_C_Reservation1.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            uC_C_Details1.Visible = true;
            uC_C_Details1.BringToFront();
        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            uC_C_Details1.Visible = false;
            uC_C_CusDetails1.Visible = false;
            uC_C_Reservation1.Visible = false;
            btnCustomer.PerformClick();
        }

        private void btnVC_Click(object sender, EventArgs e)
        {
            uC_C_CusDetails1.Visible = true;
            uC_C_CusDetails1.BringToFront();
        }

        private void uC_C_CusDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Restaurant1 : Form
    {
        public Restaurant1()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_R_Dashboard2.Visible = true;
            uC_R_Dashboard2.BringToFront();          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uC_R_AddFood1.Visible = true;
            uC_R_AddFood1.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            uC_R_ViewFood1.Visible = true;
            uC_R_ViewFood1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_R_UpdateFood1.Visible = true;
            uC_R_UpdateFood1.BringToFront();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Reserve re = new Reserve();
            re.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_R_PlaceOrder1.Visible = true;
            uC_R_PlaceOrder1.BringToFront();
        }

        private void Restaurant1_Load(object sender, EventArgs e)
        {
            uC_R_Dashboard2.Visible = false;
            uC_R_AddFood1.Visible = false;
            uC_R_PlaceOrder1.Visible = false;
            uC_R_UpdateFood1.Visible = false;
            uC_R_ViewFood1.Visible = true;
            btnDashboard.PerformClick();
        }
    }
}

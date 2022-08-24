using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_MS_Final.Reservation
{
    public partial class UC_C_Details : UserControl
    {
        function fn = new function();
        string query;
        string currentUser = "";

        public UC_C_Details()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        public void loadData()
        {
            query = "select c.CustomerID, c.CustomerName, c.CAddress, c.MobileNo, r.Occasion,r.Gethering,r.BookingDate,r.Discription  from customer as c, reservation as r where c.CustomerID = r.CustomerID;";
            DataSet ds = fn.getData(query);
            dg5.DataSource = ds.Tables[0];
        }
        private void UC_C_Details_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to DELETE ?";
            DelLabel.ForeColor = Color.Maroon;
            loadData();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            query = "select c.CustomerID, c.CustomerName ,c.CAddress, c.MobileNo, r.Occasion,r.Gethering,r.BookingDate,r.Discription  from customer as c, reservation as r where r.CustomerID = c.CustomerID and CustomerName like '" + txtID.Text + "%'";
            DataSet ds = fn.getData(query);
            dg5.DataSource = ds.Tables[0];
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_C_Details_Load(this, null);
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.ForeColor = Color.Red;
            DelLabel.Text = "*Click on Row to Delete the Reservation";
        }

        private void dg5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iid = int.Parse(dg5.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dr;
            dr = MessageBox.Show("Are you sure ?\nThere is no undo after delete ", "Confirm Deletion ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {

                query = "delete from reservation where CustomerID =" + iid + "";
                fn.setData(query, "Delete Successfully !!");

                loadData();
            }
            else
            {

                MessageBox.Show("Deletion Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

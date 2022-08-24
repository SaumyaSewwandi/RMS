using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_MS_Final
{
    public partial class UC_C_CusDetails : UserControl
    {
        function fn = new function();
        String query;

        public UC_C_CusDetails()
        {
            InitializeComponent();
        }

        private void dg5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iid = int.Parse(dg5.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dr;
            dr = MessageBox.Show("Are you sure ?\nThere is no undo after delete ", "Confirm Deletion ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {

                query = "delete from customer where CustomerID =" + iid + "";
                fn.setData(query, "Delete Successfully !!");

                loadData();
            }
            else
            {

                MessageBox.Show("Deletion Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            query = "select CustomerID,CustomerName,NIC,CAddress,Email,MobileNo from customer where CustomerID like'" + txtID.Text + "%'";
            DataSet ds = fn.getData(query);
            dg5.DataSource = ds.Tables[0];
        }

        public void loadData()
        {
            query = "select CustomerID,CustomerName,NIC,CAddress,Email,MobileNo from customer";
            DataSet ds = fn.getData(query);
            dg5.DataSource = ds.Tables[0];
        }

        private void UC_C_CusDetails_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to DELETE ?";
            DelLabel.ForeColor = Color.Maroon;
            loadData();
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.ForeColor = Color.Red;
            DelLabel.Text = "*Click on Row to Delete the Customer";
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_C_CusDetails_Load(this, null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_MS_Final.RestaurantUC
{
    public partial class UC_R_ViewFood : UserControl
    {
        function fn = new function();
        String query;

        public UC_R_ViewFood()
        {
            InitializeComponent();
        }

        private void UC_R_ViewFood_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to DELETE ?";
            DelLabel.ForeColor = Color.Maroon;
            loadData();
        }

        public void loadData()
        {
            query = "select ItemID,Catagory,Item_Name,Quantity,Price_Per_Unit from item";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select ItemID,Catagory,Item_Name,Quantity,Price_Per_Unit from item where ItemID like'" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_R_ViewFood_Load(this, null);
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.ForeColor = Color.Red;
            DelLabel.Text = "*Click on Row to Delete the Item";
        }      

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iid = int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dr;
            dr = MessageBox.Show("Are you sure ?\nThere is no undo after delete ", "Confirm Deletion ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                
                query = "delete from item where ItemID =" + iid + "";
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

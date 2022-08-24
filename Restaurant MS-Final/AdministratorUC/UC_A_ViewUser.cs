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
    public partial class UC_A_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        string currentUser = "";

        public UC_A_ViewUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void UC_A_ViewUser_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to DELETE ?";
            DelLabel.ForeColor = Color.Maroon;
            loadData();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select userID,userRole,name,mobile,email,username,pass from users where userID like '" + txtUserID.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iid = int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dr;
            dr = MessageBox.Show("Are you sure ?\nThere is no undo after delete ", "Confirm Deletion ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {

                query = "delete from users where userID =" + iid + "";
                fn.setData(query, "Delete Successfully !!");

                loadData();
            }
            else
            {

                MessageBox.Show("Deletion Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }       

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_A_ViewUser_Load(this, null);
        }     

        public void loadData()
        {
            query = "select userID,userRole,name,mobile,email,username,pass from users";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.ForeColor = Color.Red;
            DelLabel.Text = "*Click on Row to Delete the Item";
        }
    }
}

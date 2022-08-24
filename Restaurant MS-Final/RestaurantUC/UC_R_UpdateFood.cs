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
    public partial class UC_R_UpdateFood : UserControl
    {
        function fn = new function();
        String query;        

        public UC_R_UpdateFood()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text != "")
            {
                query = "select*from item where itemId='" + txtItemID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    cboCategory.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtItemName.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][4].ToString();                   
                    txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();                   
                }
                else
                {
                    MessageBox.Show("No food item with ID : " + txtItemID.Text + "exitst.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            txtItemID.Clear();
            cboCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            if (txtAddQuan.Text != "0")
            {
                txtAddQuan.Text = "0";
            }
            else
            {
                txtAddQuan.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String catagory = cboCategory.Text;
            String iName = txtItemName.Text;
            Int64 quantity = Int64.Parse(txtQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuan.Text);
            var ppu = txtPrice.Text;

            totalQuantity = quantity + addQuantity;

            query = "update item set Catagory='" + catagory + "',Item_Name='" + iName + "',Quantity=" + totalQuantity + ",Price_Per_Unit=" + ppu + " where ItemID='" + txtItemID.Text + "' ";
            fn.setData(query, "Food Item Details Updated.");
        }
    }
}

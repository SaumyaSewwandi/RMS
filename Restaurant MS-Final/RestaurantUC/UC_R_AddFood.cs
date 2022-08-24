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
    public partial class UC_R_AddFood : UserControl
    {
        function fn = new function();
        string query;

        public UC_R_AddFood()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemId = txtItemID.Text;
            string catagory = cboCategory.Text;
            string iName = txtItemName.Text;            
            string quantity = txtQuantity.Text;
            string ppu = txtPrice.Text;

            try
            {
                query = "insert into item(ItemID,Catagory,Item_Name,Quantity,Price_Per_Unit) values('" + itemId + "','" + catagory + "','" + iName + "','" + quantity + "','" + ppu + "')";
                fn.setData(query, "Added Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Item ID Allready Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtItemID.Clear();
            txtItemName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cboCategory.SelectedIndex = -1;
        }
    }
}

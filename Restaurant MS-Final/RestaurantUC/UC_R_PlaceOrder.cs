using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Restaurant_MS_Final.RestaurantUC
{
    public partial class UC_R_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_R_PlaceOrder()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.Clear();

            String name = listBox1.GetItemText(listBox1.SelectedItem);

            txtItemName.Text = name;
            query = "select ItemID,Price_Per_Unit from item where Item_Name='" + name + "' ";
            ds = fn.getData(query);
            txtItemID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][1].ToString();

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = cobCategory.Text;
            query = "select Item_Name from item where Catagory='" + category + "'";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        Decimal amount;
        int valueAmount;
        String valueID;
        protected Int64 noOfunit;

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {        
            try
            {
                valueAmount = int.Parse(dg2.Rows[e.RowIndex].Cells[4].Value.ToString());
                valueID = dg2.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(dg2.Rows[e.RowIndex].Cells[3].Value.ToString());

            }
            catch (Exception)
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {         
            if (valueID != null)
            {
                try
                {
                    dg2.Rows.RemoveAt(this.dg2.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select Quantity from item where ItemID= '" + valueID + "' ";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "update item set Quantity='" + newQuantity + "' where ItemID='" + valueID + "' ";
                    fn.setData(query, "Medicine Remove from Cart.");
                    Gtotal = Gtotal - valueAmount;
                    txtGrandTotal.Text = "Rs. " + Gtotal.ToString();
                }

                UC_R_PlaceOrder_Load(this, null);

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //save
            String now = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime date = DateTime.Parse(now);

            
            query = "insert into OrderDetail (Odate,Total) Values ('" + date + "','" + Gtotal + "')";
            fn.setData(query, "Data Added Successfully.");             

            //Today income
            Todayprofit();


            //print            
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payble Amount : " + Gtotal;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dg2);

            Gtotal = 0;
            txtGrandTotal.Text = "Rs. 00";
            dg2.DataSource = 0;
        }

        protected int n, total = 0;
        Decimal Gtotal = 0;


        private void UC_R_PlaceOrder_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd,dd MMMM yyyy hh:mm:ss tt");
            txtGrandTotal.Text = "Rs. " + Gtotal;
            Todayprofit();

            listBox1.Items.Clear();

        }
        protected Int64 quantity, newQuantity;

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text != "")
            {
                query = "select quantity from item where ItemID='" + txtItemID.Text + "' ";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtQuantity.Text);

                if (newQuantity >= 0)
                {
                    n = dg2.Rows.Add();
                    dg2.Rows[n].Cells[0].Value = txtItemID.Text;
                    dg2.Rows[n].Cells[1].Value = txtItemName.Text;
                    dg2.Rows[n].Cells[2].Value = txtPrice.Text;
                    dg2.Rows[n].Cells[3].Value = txtQuantity.Text;
                    dg2.Rows[n].Cells[4].Value = txtTotal.Text;

                    Gtotal = Gtotal + int.Parse(txtTotal.Text);
                    txtGrandTotal.Text = "Rs. " + Gtotal.ToString();

                    query = "update item set Quantity='" + newQuantity + "' where ItemID='" + txtItemID.Text + "' ";
                    fn.setData(query, "Item Added");

                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock.\n Only " + quantity + " Left", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                clearAll();
                UC_R_PlaceOrder_Load(this, null);

            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                Int64 ppu = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);
                Int64 total = ppu * quan;
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTotal.Clear();
            }
        }

        public void Todayprofit()
        {          
            String now = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime date = DateTime.Parse(now);

            String query = "select sum(Total) from OrderDetail where Odate = '" + date + "'";
            DataSet ds = fn.getData(query);

            try
            {
                lblProfit.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void clearAll()
        {
            cobCategory.SelectedIndex=-1;
            txtItemID.Clear();
            txtItemName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtTotal.Clear();           
        }
    }
}

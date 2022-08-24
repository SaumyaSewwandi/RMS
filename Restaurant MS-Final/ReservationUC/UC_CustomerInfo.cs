using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_MS_Final.Reservation
{
    public partial class UC_CustomerInfo : UserControl
    {
        function fn = new function();
        string query;

        public UC_CustomerInfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cid = txtCusID.Text;
            string cname = txtCusName.Text;
            string nic = txtNic.Text;          
            string add = txtAddress.Text;
            string email = txtEmail.Text;
            string mobile = txtMobile.Text;

            try
            {
                query = "insert into customer(CustomerID,CustomerName,NIC,CAddress,Email,MobileNo) values('" + cid + "','" + cname + "','" + nic + "','" + add + "','" + email + "','" + mobile + "')";
                fn.setData(query, "Sign Up Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Customer ID Allready Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearAll()
        {
            txtCusID.Clear();
            txtCusName.Clear();
            txtNic.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobile.Clear();           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtCusID.Text != "")
            {
                query = "select*from customer where CustomerID='" + txtCusID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtCusName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtNic.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("No customer with ID : " + txtCusID.Text + "exitst.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Cname = txtCusName.Text;
            string Nic = txtNic.Text;
            string Add = txtMobile.Text;
            string Email = txtEmail.Text;
            string Mobile = txtMobile.Text;

            query = "update customer set CustomerName='" + Cname + "',NIC='" + Nic + "',CAddress='" + Add + "',Email='" + Email + "',MobileNo='" + Mobile + "' where CustomerID='" + txtCusID.Text + "' ";
            fn.setData(query, "Customer Details Updated");
        }
    }
}

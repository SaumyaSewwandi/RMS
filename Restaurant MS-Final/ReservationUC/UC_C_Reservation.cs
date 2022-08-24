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
    public partial class UC_C_Reservation : UserControl
    {
        function fn = new function();
        String query;

        public UC_C_Reservation()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String cid = txtCusId.Text;
            String occ = txtOccasion.Text;
            String dis = txtDiscription.Text;
            String dob = txtDate.Text;
            String gethering = txtGatering.Text;

            try
            {
                query = "insert into reservation (CustomerID,Occasion,Discription,BookingDate,Gethering) values('" + cid+ "','" +occ+ "','" +dis+ "','" +dob+ "','" +gethering+ "')";
                fn.setData(query,"Sign Up Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Reservation Allready Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void clearAll()
        {
            txtCusId.Clear();
            txtDiscription.Clear();
            txtOccasion.Clear();
            txtDate.ResetText();
            txtGatering.Clear();           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtCusId.Text != "")
            {
                query = "select*from reservation where CustomerID='" + txtCusId.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtOccasion.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtDiscription.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtGatering.Text = ds.Tables[0].Rows[0][5].ToString();                   
                }
                else
                {
                    MessageBox.Show("No reservation with ID : " + txtCusId.Text + " exitst.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String Occ = txtOccasion.Text;
            String Dis = txtDiscription.Text;
            String Dob = txtDate.Text;
            String Gethering = txtGatering.Text;

            query = "update reservation set Occasion='" + Occ + "',Discription='" + Dis + "',BookingDate='" + Dob + "',Gethering='" + Gethering + "' where CustomerID='" + txtCusId.Text + "' ";
            fn.setData(query, "Customer Details Updated");
        }
    }
}

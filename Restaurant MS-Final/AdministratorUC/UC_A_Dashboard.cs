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
    public partial class UC_A_Dashboard : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;

        public UC_A_Dashboard()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_A_Dashboard_Load(this, null);
        }

        private void UC_A_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole='Administrator'";
            ds = fn.getData(query);
            setLable(ds, AdminLabel);

            query = "select count(userRole)from users where userRole='Restaurant'";
            ds = fn.getData(query);
            setLable(ds, RestLable);

            query = "select count(CustomerID)from customer";
            ds = fn.getData(query);
            setLable(ds, CusLable);
        }

        private void setLable(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }
    }
}

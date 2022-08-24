using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_MS_Final
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        int starpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            starpoint += 1;
            guna2ProgressBar1.Value = starpoint;
            if (guna2ProgressBar1.Value == 100)
            {
                guna2ProgressBar1.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

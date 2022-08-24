using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Restaurant_MS_Final
{
    public partial class sendCode : Form
    {
        string randomCode;
        public static string to;
        string username = sendCode.to;

        public sendCode()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "tummytime219@gmail.com";
            pass = "Univotec@123";
            messageBody = "Your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send successfully", "Send Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                label5.Visible = true;
            }
        }

        private void btnVerCode_Click(object sender, EventArgs e)
        {

            if (randomCode==(txtVerCode.Text).ToString())
            {
                to = txtEmail.Text;

                this.Width = 331;

                groupBox1.Visible = false;
                groupBox2.Visible = true;

                groupBox2.Location = new Point(12, 43);
                groupBox2.Width = 307;
                groupBox2.Height = 414;
            }
            else
            {
                MessageBox.Show("Wrong code","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void sendCode_Load(object sender, EventArgs e)
        {
            this.Width = 331;

            groupBox1.Visible = true;
            groupBox2.Visible = false;

            groupBox1.Location = new Point(12, 43);
            groupBox1.Width = 307;
            groupBox1.Height = 414;

            btnLogin.Visible = false;
            label5.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetPassVer.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=SEWWANDI\\SQLEXPRESS;Initial Catalog=RestaurantMS-Final;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE[dbo].[users] SET [password] = '" + txtResetPassVer.Text + "' WHERE username='" + username + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reset successfully","Reser Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLogin.Visible = true;
            }
            else
            {
                MessageBox.Show("The new password do not match /nso enter same password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }
    }
}

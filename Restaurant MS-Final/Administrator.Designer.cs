namespace Restaurant_MS_Final
{
    partial class Administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewUser = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_A_Profile1 = new Restaurant_MS_Final.AdministratorUC.UC_A_Profile();
            this.uC_A_ViewUser1 = new Restaurant_MS_Final.AdministratorUC.UC_A_ViewUser();
            this.uC_A_AddUser1 = new Restaurant_MS_Final.AdministratorUC.UC_A_AddUser();
            this.uC_A_Dashboard1 = new Restaurant_MS_Final.AdministratorUC.UC_A_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 1182);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 57);
            this.label1.TabIndex = 18;
            this.label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddUser.BorderRadius = 23;
            this.btnAddUser.BorderThickness = 1;
            this.btnAddUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddUser.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddUser.CheckedState.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddUser.CheckedState.Parent = this.btnAddUser;
            this.btnAddUser.CustomImages.Parent = this.btnAddUser;
            this.btnAddUser.FillColor = System.Drawing.Color.Gold;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.HoverState.Parent = this.btnAddUser;
            this.btnAddUser.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddUser.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnAddUser.Location = new System.Drawing.Point(62, 540);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.ShadowDecoration.Parent = this.btnAddUser;
            this.btnAddUser.Size = new System.Drawing.Size(420, 69);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.userNameLabel.Location = new System.Drawing.Point(134, 1069);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(238, 34);
            this.userNameLabel.TabIndex = 17;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDashboard.BorderRadius = 23;
            this.btnDashboard.BorderThickness = 1;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.Gold;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDashboard.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnDashboard.Location = new System.Drawing.Point(62, 442);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(420, 69);
            this.btnDashboard.TabIndex = 15;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLogOut.BorderRadius = 23;
            this.btnLogOut.BorderThickness = 1;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.Gold;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogOut.Location = new System.Drawing.Point(62, 835);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(420, 69);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProfile.BorderRadius = 23;
            this.btnProfile.BorderThickness = 1;
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnProfile.CheckedState.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnProfile.CheckedState.Parent = this.btnProfile;
            this.btnProfile.CustomImages.Parent = this.btnProfile;
            this.btnProfile.FillColor = System.Drawing.Color.Gold;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.HoverState.Parent = this.btnProfile;
            this.btnProfile.ImageSize = new System.Drawing.Size(35, 35);
            this.btnProfile.Location = new System.Drawing.Point(62, 737);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ShadowDecoration.Parent = this.btnProfile;
            this.btnProfile.Size = new System.Drawing.Size(420, 69);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnViewUser.BorderRadius = 23;
            this.btnViewUser.BorderThickness = 1;
            this.btnViewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewUser.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewUser.CheckedState.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnViewUser.CheckedState.Parent = this.btnViewUser;
            this.btnViewUser.CustomImages.Parent = this.btnViewUser;
            this.btnViewUser.FillColor = System.Drawing.Color.Gold;
            this.btnViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnViewUser.ForeColor = System.Drawing.Color.Black;
            this.btnViewUser.HoverState.Parent = this.btnViewUser;
            this.btnViewUser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnViewUser.Location = new System.Drawing.Point(62, 638);
            this.btnViewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.ShadowDecoration.Parent = this.btnViewUser;
            this.btnViewUser.Size = new System.Drawing.Size(420, 69);
            this.btnViewUser.TabIndex = 2;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_A_Profile1);
            this.panel2.Controls.Add(this.uC_A_ViewUser1);
            this.panel2.Controls.Add(this.uC_A_AddUser1);
            this.panel2.Controls.Add(this.uC_A_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(414, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1650, 1185);
            this.panel2.TabIndex = 5;
            // 
            // uC_A_Profile1
            // 
            this.uC_A_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_A_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_A_Profile1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uC_A_Profile1.Name = "uC_A_Profile1";
            this.uC_A_Profile1.Size = new System.Drawing.Size(1650, 1185);
            this.uC_A_Profile1.TabIndex = 3;
            this.uC_A_Profile1.Load += new System.EventHandler(this.uC_A_Profile1_Load);
            // 
            // uC_A_ViewUser1
            // 
            this.uC_A_ViewUser1.BackColor = System.Drawing.Color.White;
            this.uC_A_ViewUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_A_ViewUser1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uC_A_ViewUser1.Name = "uC_A_ViewUser1";
            this.uC_A_ViewUser1.Size = new System.Drawing.Size(1650, 1185);
            this.uC_A_ViewUser1.TabIndex = 2;
            // 
            // uC_A_AddUser1
            // 
            this.uC_A_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_A_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_A_AddUser1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uC_A_AddUser1.Name = "uC_A_AddUser1";
            this.uC_A_AddUser1.Size = new System.Drawing.Size(1650, 1185);
            this.uC_A_AddUser1.TabIndex = 1;
            // 
            // uC_A_Dashboard1
            // 
            this.uC_A_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_A_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_A_Dashboard1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.uC_A_Dashboard1.Name = "uC_A_Dashboard1";
            this.uC_A_Dashboard1.Size = new System.Drawing.Size(1650, 1185);
            this.uC_A_Dashboard1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnViewUser;
        private System.Windows.Forms.Panel panel2;
        private AdministratorUC.UC_A_Dashboard uC_A_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdministratorUC.UC_A_AddUser uC_A_AddUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdministratorUC.UC_A_ViewUser uC_A_ViewUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AdministratorUC.UC_A_Profile uC_A_Profile1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    }
}
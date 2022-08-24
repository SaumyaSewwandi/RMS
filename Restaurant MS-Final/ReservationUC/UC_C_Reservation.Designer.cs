namespace Restaurant_MS_Final.Reservation
{
    partial class UC_C_Reservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGatering = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOccasion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusId = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Kaiti Std R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 40);
            this.label1.TabIndex = 60;
            this.label1.Text = "Add Reservation";
            // 
            // txtDate
            // 
            this.txtDate.BorderColor = System.Drawing.Color.Tan;
            this.txtDate.BorderThickness = 1;
            this.txtDate.CheckedState.Parent = this.txtDate;
            this.txtDate.FillColor = System.Drawing.Color.Tan;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.HoverState.Parent = this.txtDate;
            this.txtDate.Location = new System.Drawing.Point(645, 213);
            this.txtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.ShadowDecoration.Parent = this.txtDate;
            this.txtDate.Size = new System.Drawing.Size(340, 35);
            this.txtDate.TabIndex = 79;
            this.txtDate.Value = new System.DateTime(2021, 1, 23, 18, 40, 47, 70);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(641, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 78;
            this.label6.Text = "Date of Booking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(641, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 77;
            this.label5.Text = "Gethering";
            // 
            // txtGatering
            // 
            this.txtGatering.BorderColor = System.Drawing.Color.Tan;
            this.txtGatering.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGatering.DefaultText = "";
            this.txtGatering.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGatering.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGatering.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGatering.DisabledState.Parent = this.txtGatering;
            this.txtGatering.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGatering.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.txtGatering.FocusedState.Parent = this.txtGatering;
            this.txtGatering.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtGatering.ForeColor = System.Drawing.Color.Black;
            this.txtGatering.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtGatering.HoverState.Parent = this.txtGatering;
            this.txtGatering.Location = new System.Drawing.Point(645, 329);
            this.txtGatering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGatering.Name = "txtGatering";
            this.txtGatering.PasswordChar = '\0';
            this.txtGatering.PlaceholderText = "";
            this.txtGatering.SelectedText = "";
            this.txtGatering.ShadowDecoration.Parent = this.txtGatering;
            this.txtGatering.Size = new System.Drawing.Size(340, 35);
            this.txtGatering.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGatering.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Discription";
            // 
            // txtDiscription
            // 
            this.txtDiscription.BorderColor = System.Drawing.Color.Tan;
            this.txtDiscription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscription.DefaultText = "";
            this.txtDiscription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscription.DisabledState.Parent = this.txtDiscription;
            this.txtDiscription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscription.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.txtDiscription.FocusedState.Parent = this.txtDiscription;
            this.txtDiscription.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtDiscription.ForeColor = System.Drawing.Color.Black;
            this.txtDiscription.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtDiscription.HoverState.Parent = this.txtDiscription;
            this.txtDiscription.Location = new System.Drawing.Point(96, 445);
            this.txtDiscription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.PasswordChar = '\0';
            this.txtDiscription.PlaceholderText = "";
            this.txtDiscription.SelectedText = "";
            this.txtDiscription.ShadowDecoration.Parent = this.txtDiscription;
            this.txtDiscription.Size = new System.Drawing.Size(340, 35);
            this.txtDiscription.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDiscription.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 73;
            this.label2.Text = "Occasion";
            // 
            // txtOccasion
            // 
            this.txtOccasion.BorderColor = System.Drawing.Color.Tan;
            this.txtOccasion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOccasion.DefaultText = "";
            this.txtOccasion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOccasion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOccasion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOccasion.DisabledState.Parent = this.txtOccasion;
            this.txtOccasion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOccasion.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.txtOccasion.FocusedState.Parent = this.txtOccasion;
            this.txtOccasion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtOccasion.ForeColor = System.Drawing.Color.Black;
            this.txtOccasion.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtOccasion.HoverState.Parent = this.txtOccasion;
            this.txtOccasion.Location = new System.Drawing.Point(96, 329);
            this.txtOccasion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOccasion.Name = "txtOccasion";
            this.txtOccasion.PasswordChar = '\0';
            this.txtOccasion.PlaceholderText = "";
            this.txtOccasion.SelectedText = "";
            this.txtOccasion.ShadowDecoration.Parent = this.txtOccasion;
            this.txtOccasion.Size = new System.Drawing.Size(340, 35);
            this.txtOccasion.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtOccasion.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "Customer ID";
            // 
            // txtCusId
            // 
            this.txtCusId.BorderColor = System.Drawing.Color.Tan;
            this.txtCusId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusId.DefaultText = "";
            this.txtCusId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusId.DisabledState.Parent = this.txtCusId;
            this.txtCusId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusId.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.txtCusId.FocusedState.Parent = this.txtCusId;
            this.txtCusId.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCusId.ForeColor = System.Drawing.Color.Black;
            this.txtCusId.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtCusId.HoverState.Parent = this.txtCusId;
            this.txtCusId.Location = new System.Drawing.Point(96, 213);
            this.txtCusId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.PasswordChar = '\0';
            this.txtCusId.PlaceholderText = "";
            this.txtCusId.SelectedText = "";
            this.txtCusId.ShadowDecoration.Parent = this.txtCusId;
            this.txtCusId.Size = new System.Drawing.Size(340, 35);
            this.txtCusId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCusId.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.panel1.Location = new System.Drawing.Point(539, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 400);
            this.panel1.TabIndex = 98;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnSearch.BorderRadius = 18;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnSearch.Font = new System.Drawing.Font("Adobe Kaiti Std R", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(326, 256);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(110, 34);
            this.btnSearch.TabIndex = 102;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnReset.BorderRadius = 19;
            this.btnReset.BorderThickness = 1;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnReset.Font = new System.Drawing.Font("Adobe Kaiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(885, 444);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(100, 36);
            this.btnReset.TabIndex = 104;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnSignUp.BorderRadius = 19;
            this.btnSignUp.BorderThickness = 1;
            this.btnSignUp.CheckedState.Parent = this.btnSignUp;
            this.btnSignUp.CustomImages.Parent = this.btnSignUp;
            this.btnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnSignUp.Font = new System.Drawing.Font("Adobe Kaiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnSignUp.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSignUp.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnSignUp.HoverState.Parent = this.btnSignUp;
            this.btnSignUp.Location = new System.Drawing.Point(645, 444);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.ShadowDecoration.Parent = this.btnSignUp;
            this.btnSignUp.Size = new System.Drawing.Size(100, 36);
            this.btnSignUp.TabIndex = 103;
            this.btnSignUp.Text = "Add";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnUpdate.BorderRadius = 19;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnUpdate.Font = new System.Drawing.Font("Adobe Kaiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(765, 444);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 105;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UC_C_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGatering);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOccasion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCusId);
            this.Controls.Add(this.label1);
            this.Name = "UC_C_Reservation";
            this.Size = new System.Drawing.Size(1100, 770);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtGatering;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscription;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtOccasion;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtCusId;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}

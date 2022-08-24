namespace Restaurant_MS_Final.RestaurantUC
{
    partial class UC_R_PlaceOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_R_PlaceOrder));
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cobCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddtoCart = new Guna.UI2.WinForms.Guna2Button();
            this.dg2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtGrandTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSync = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.BorderColor = System.Drawing.Color.Tan;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.DefaultText = "";
            this.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.DisabledState.Parent = this.txtItemName;
            this.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.txtItemName.FocusedState.Parent = this.txtItemName;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtItemName.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtItemName.HoverState.Parent = this.txtItemName;
            this.txtItemName.Location = new System.Drawing.Point(367, 218);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderText = "";
            this.txtItemName.SelectedText = "";
            this.txtItemName.ShadowDecoration.Parent = this.txtItemName;
            this.txtItemName.Size = new System.Drawing.Size(300, 35);
            this.txtItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItemName.TabIndex = 65;
            // 
            // cobCategory
            // 
            this.cobCategory.BackColor = System.Drawing.Color.White;
            this.cobCategory.BorderColor = System.Drawing.Color.Tan;
            this.cobCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cobCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCategory.FocusedColor = System.Drawing.Color.Tan;
            this.cobCategory.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.cobCategory.FocusedState.Parent = this.cobCategory;
            this.cobCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cobCategory.ForeColor = System.Drawing.Color.Black;
            this.cobCategory.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.cobCategory.HoverState.Parent = this.cobCategory;
            this.cobCategory.ItemHeight = 30;
            this.cobCategory.Items.AddRange(new object[] {
            "Fried Rice (Samba)",
            "Fried Rice (Basmathi)",
            "Dessert",
            "Rice & Curry",
            "Noodles",
            "Koththu",
            "Biryani & Nasi Goreng",
            "Family Pack",
            "Devilld",
            "Fruit Juice",
            "Ice Cream"});
            this.cobCategory.ItemsAppearance.Parent = this.cobCategory;
            this.cobCategory.Location = new System.Drawing.Point(70, 137);
            this.cobCategory.Name = "cobCategory";
            this.cobCategory.ShadowDecoration.Parent = this.cobCategory;
            this.cobCategory.Size = new System.Drawing.Size(235, 36);
            this.cobCategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cobCategory.TabIndex = 58;
            this.cobCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Kaiti Std R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 59;
            this.label1.Text = "Place Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 61;
            this.label2.Text = "Catagory";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(70, 212);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 483);
            this.listBox1.TabIndex = 63;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 67;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(734, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 68;
            this.label6.Text = "Price Per Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(734, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 69;
            this.label7.Text = "Total Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.Tan;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(738, 138);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(300, 35);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 70;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColor = System.Drawing.Color.Tan;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(738, 218);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(300, 35);
            this.txtTotal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotal.TabIndex = 71;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnAddtoCart.BorderRadius = 19;
            this.btnAddtoCart.BorderThickness = 1;
            this.btnAddtoCart.CheckedState.Parent = this.btnAddtoCart;
            this.btnAddtoCart.CustomImages.Parent = this.btnAddtoCart;
            this.btnAddtoCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnAddtoCart.Font = new System.Drawing.Font("Adobe Kaiti Std R", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddtoCart.ForeColor = System.Drawing.Color.White;
            this.btnAddtoCart.HoverState.Parent = this.btnAddtoCart;
            this.btnAddtoCart.Location = new System.Drawing.Point(892, 302);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.ShadowDecoration.Parent = this.btnAddtoCart;
            this.btnAddtoCart.Size = new System.Drawing.Size(146, 36);
            this.btnAddtoCart.TabIndex = 72;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // dg2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg2.BackgroundColor = System.Drawing.Color.White;
            this.dg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg2.ColumnHeadersHeight = 21;
            this.dg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg2.EnableHeadersVisualStyles = false;
            this.dg2.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dg2.Location = new System.Drawing.Point(367, 370);
            this.dg2.Name = "dg2";
            this.dg2.ReadOnly = true;
            this.dg2.RowHeadersVisible = false;
            this.dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg2.Size = new System.Drawing.Size(671, 186);
            this.dg2.TabIndex = 73;
            this.dg2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg2.ThemeStyle.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dg2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.dg2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dg2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg2.ThemeStyle.HeaderStyle.Height = 21;
            this.dg2.ThemeStyle.ReadOnly = true;
            this.dg2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dg2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg2.ThemeStyle.RowsStyle.Height = 22;
            this.dg2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            this.dg2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg2_CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ItemID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price Per Unit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnRemove.BorderRadius = 19;
            this.btnRemove.BorderThickness = 1;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.Color.White;
            this.btnRemove.Font = new System.Drawing.Font("Adobe Kaiti Std R", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(367, 592);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(146, 36);
            this.btnRemove.TabIndex = 74;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnPrint.BorderRadius = 19;
            this.btnPrint.BorderThickness = 1;
            this.btnPrint.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnPrint.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPrint.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.btnPrint.Font = new System.Drawing.Font("Adobe Kaiti Std R", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(869, 592);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(169, 36);
            this.btnPrint.TabIndex = 75;
            this.btnPrint.Text = "Purchase & Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.lblGrandTotal.Location = new System.Drawing.Point(565, 599);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(104, 22);
            this.lblGrandTotal.TabIndex = 76;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.White;
            this.txtGrandTotal.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrandTotal.DefaultText = "";
            this.txtGrandTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrandTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrandTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrandTotal.DisabledState.Parent = this.txtGrandTotal;
            this.txtGrandTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrandTotal.FillColor = System.Drawing.Color.PaleGoldenrod;
            this.txtGrandTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrandTotal.FocusedState.Parent = this.txtGrandTotal;
            this.txtGrandTotal.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.txtGrandTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrandTotal.HoverState.Parent = this.txtGrandTotal;
            this.txtGrandTotal.Location = new System.Drawing.Point(675, 593);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.PasswordChar = '\0';
            this.txtGrandTotal.PlaceholderText = "";
            this.txtGrandTotal.SelectedText = "";
            this.txtGrandTotal.ShadowDecoration.Parent = this.txtGrandTotal;
            this.txtGrandTotal.Size = new System.Drawing.Size(138, 35);
            this.txtGrandTotal.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label8.Location = new System.Drawing.Point(363, 669);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 22);
            this.label8.TabIndex = 78;
            this.label8.Text = "Today Income";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 672);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 19);
            this.label10.TabIndex = 79;
            this.label10.Text = "Rs.";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(515, 672);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(0, 19);
            this.lblProfit.TabIndex = 80;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(363, 700);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 19);
            this.lbldate.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // btnSync
            // 
            this.btnSync.CheckedState.Parent = this.btnSync;
            this.btnSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSync.CustomImages.Parent = this.btnSync;
            this.btnSync.FillColor = System.Drawing.Color.White;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSync.HoverState.Parent = this.btnSync;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageSize = new System.Drawing.Size(26, 26);
            this.btnSync.Location = new System.Drawing.Point(233, 38);
            this.btnSync.Name = "btnSync";
            this.btnSync.PressedColor = System.Drawing.Color.White;
            this.btnSync.ShadowDecoration.Parent = this.btnSync;
            this.btnSync.Size = new System.Drawing.Size(26, 26);
            this.btnSync.TabIndex = 83;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderColor = System.Drawing.Color.Tan;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(367, 298);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(300, 35);
            this.txtQuantity.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtQuantity.TabIndex = 84;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 86;
            this.label9.Text = "Item ID";
            // 
            // txtItemID
            // 
            this.txtItemID.BorderColor = System.Drawing.Color.Tan;
            this.txtItemID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemID.DefaultText = "";
            this.txtItemID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemID.DisabledState.Parent = this.txtItemID;
            this.txtItemID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemID.FocusedState.BorderColor = System.Drawing.Color.Tan;
            this.txtItemID.FocusedState.Parent = this.txtItemID;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtItemID.ForeColor = System.Drawing.Color.Black;
            this.txtItemID.HoverState.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtItemID.HoverState.Parent = this.txtItemID;
            this.txtItemID.Location = new System.Drawing.Point(367, 138);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.PasswordChar = '\0';
            this.txtItemID.PlaceholderText = "";
            this.txtItemID.SelectedText = "";
            this.txtItemID.ShadowDecoration.Parent = this.txtItemID;
            this.txtItemID.Size = new System.Drawing.Size(300, 35);
            this.txtItemID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItemID.TabIndex = 85;
            // 
            // UC_R_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cobCategory);
            this.Controls.Add(this.txtItemName);
            this.Name = "UC_R_PlaceOrder";
            this.Size = new System.Drawing.Size(1100, 770);
            this.Load += new System.EventHandler(this.UC_R_PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private Guna.UI2.WinForms.Guna2ComboBox cobCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2Button btnAddtoCart;
        private Guna.UI2.WinForms.Guna2DataGridView dg2;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.Label lblGrandTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtGrandTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSync;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtItemID;
    }
}

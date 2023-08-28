namespace Market_Management_System.Buyerforms
{
    partial class formMyCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buyerLabelButtonWelcome = new Guna.UI2.WinForms.Guna2Button();
            this.buyerLabelFullname = new System.Windows.Forms.Label();
            this.buyerButtonPurchaseHistory = new Guna.UI2.WinForms.Guna2Button();
            this.buyerButtonMyCart = new Guna.UI2.WinForms.Guna2Button();
            this.buyerButtonAvailableProducts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonShowAllProducts = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxFilterByCategory = new System.Windows.Forms.ComboBox();
            this.labelFilterByCategory = new System.Windows.Forms.Label();
            this.buttonFilter = new Guna.UI2.WinForms.Guna2Button();
            this.buttonConfirmPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewMyCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelMyCart = new System.Windows.Forms.Label();
            this.textBoxTotalBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonRemoveFromCart = new Guna.UI2.WinForms.Guna2Button();
            this.labelTotalBill = new System.Windows.Forms.Label();
            this.buyerButtonLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMyCart)).BeginInit();
            this.SuspendLayout();
            // 
            // buyerLabelButtonWelcome
            // 
            this.buyerLabelButtonWelcome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buyerLabelButtonWelcome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyerLabelButtonWelcome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyerLabelButtonWelcome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyerLabelButtonWelcome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyerLabelButtonWelcome.FillColor = System.Drawing.SystemColors.Menu;
            this.buyerLabelButtonWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerLabelButtonWelcome.ForeColor = System.Drawing.Color.Black;
            this.buyerLabelButtonWelcome.Location = new System.Drawing.Point(-11, -15);
            this.buyerLabelButtonWelcome.Name = "buyerLabelButtonWelcome";
            this.buyerLabelButtonWelcome.Size = new System.Drawing.Size(140, 59);
            this.buyerLabelButtonWelcome.TabIndex = 4;
            this.buyerLabelButtonWelcome.Text = "Welcome";
            // 
            // buyerLabelFullname
            // 
            this.buyerLabelFullname.AutoSize = true;
            this.buyerLabelFullname.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerLabelFullname.Location = new System.Drawing.Point(-1, 34);
            this.buyerLabelFullname.Name = "buyerLabelFullname";
            this.buyerLabelFullname.Size = new System.Drawing.Size(80, 32);
            this.buyerLabelFullname.TabIndex = 3;
            this.buyerLabelFullname.Text = "User !";
            // 
            // buyerButtonPurchaseHistory
            // 
            this.buyerButtonPurchaseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buyerButtonPurchaseHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyerButtonPurchaseHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyerButtonPurchaseHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyerButtonPurchaseHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyerButtonPurchaseHistory.FillColor = System.Drawing.SystemColors.Control;
            this.buyerButtonPurchaseHistory.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerButtonPurchaseHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buyerButtonPurchaseHistory.Location = new System.Drawing.Point(2, 325);
            this.buyerButtonPurchaseHistory.Name = "buyerButtonPurchaseHistory";
            this.buyerButtonPurchaseHistory.Size = new System.Drawing.Size(276, 77);
            this.buyerButtonPurchaseHistory.TabIndex = 8;
            this.buyerButtonPurchaseHistory.Text = "Purchase History";
            this.buyerButtonPurchaseHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buyerButtonPurchaseHistory.Click += new System.EventHandler(this.buyerButtonPurchaseHistory_Click);
            // 
            // buyerButtonMyCart
            // 
            this.buyerButtonMyCart.BackColor = System.Drawing.SystemColors.Control;
            this.buyerButtonMyCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyerButtonMyCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyerButtonMyCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyerButtonMyCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyerButtonMyCart.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerButtonMyCart.ForeColor = System.Drawing.SystemColors.Control;
            this.buyerButtonMyCart.Location = new System.Drawing.Point(2, 253);
            this.buyerButtonMyCart.Name = "buyerButtonMyCart";
            this.buyerButtonMyCart.Size = new System.Drawing.Size(276, 72);
            this.buyerButtonMyCart.TabIndex = 9;
            this.buyerButtonMyCart.Text = "My Cart";
            this.buyerButtonMyCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buyerButtonAvailableProducts
            // 
            this.buyerButtonAvailableProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buyerButtonAvailableProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyerButtonAvailableProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyerButtonAvailableProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyerButtonAvailableProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyerButtonAvailableProducts.FillColor = System.Drawing.SystemColors.Control;
            this.buyerButtonAvailableProducts.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerButtonAvailableProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buyerButtonAvailableProducts.Location = new System.Drawing.Point(2, 178);
            this.buyerButtonAvailableProducts.Name = "buyerButtonAvailableProducts";
            this.buyerButtonAvailableProducts.Size = new System.Drawing.Size(276, 75);
            this.buyerButtonAvailableProducts.TabIndex = 10;
            this.buyerButtonAvailableProducts.Text = "Available Products";
            this.buyerButtonAvailableProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buyerButtonAvailableProducts.Click += new System.EventHandler(this.buyerButtonAvailableProducts_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.buttonConfirmPurchase);
            this.guna2Panel1.Controls.Add(this.DataGridViewMyCart);
            this.guna2Panel1.Controls.Add(this.labelMyCart);
            this.guna2Panel1.Controls.Add(this.textBoxTotalBill);
            this.guna2Panel1.Controls.Add(this.buttonRemoveFromCart);
            this.guna2Panel1.Controls.Add(this.labelTotalBill);
            this.guna2Panel1.Location = new System.Drawing.Point(264, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(847, 658);
            this.guna2Panel1.TabIndex = 11;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.buttonShowAllProducts);
            this.guna2Panel2.Controls.Add(this.comboBoxFilterByCategory);
            this.guna2Panel2.Controls.Add(this.labelFilterByCategory);
            this.guna2Panel2.Controls.Add(this.buttonFilter);
            this.guna2Panel2.Location = new System.Drawing.Point(624, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(207, 112);
            this.guna2Panel2.TabIndex = 15;
            // 
            // buttonShowAllProducts
            // 
            this.buttonShowAllProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonShowAllProducts.BorderRadius = 10;
            this.buttonShowAllProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonShowAllProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonShowAllProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonShowAllProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonShowAllProducts.FillColor = System.Drawing.SystemColors.Control;
            this.buttonShowAllProducts.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAllProducts.ForeColor = System.Drawing.Color.Black;
            this.buttonShowAllProducts.Location = new System.Drawing.Point(85, 88);
            this.buttonShowAllProducts.Name = "buttonShowAllProducts";
            this.buttonShowAllProducts.Size = new System.Drawing.Size(122, 21);
            this.buttonShowAllProducts.TabIndex = 17;
            this.buttonShowAllProducts.Text = "Remove filter";
            this.buttonShowAllProducts.Click += new System.EventHandler(this.buttonShowAllProducts_Click);
            // 
            // comboBoxFilterByCategory
            // 
            this.comboBoxFilterByCategory.FormattingEnabled = true;
            this.comboBoxFilterByCategory.Location = new System.Drawing.Point(85, 51);
            this.comboBoxFilterByCategory.Name = "comboBoxFilterByCategory";
            this.comboBoxFilterByCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterByCategory.TabIndex = 16;
            // 
            // labelFilterByCategory
            // 
            this.labelFilterByCategory.AutoSize = true;
            this.labelFilterByCategory.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterByCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFilterByCategory.Location = new System.Drawing.Point(32, 23);
            this.labelFilterByCategory.Name = "labelFilterByCategory";
            this.labelFilterByCategory.Size = new System.Drawing.Size(151, 21);
            this.labelFilterByCategory.TabIndex = 15;
            this.labelFilterByCategory.Text = "Filter By Category";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonFilter.BorderRadius = 10;
            this.buttonFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFilter.FillColor = System.Drawing.SystemColors.Control;
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.ForeColor = System.Drawing.Color.Black;
            this.buttonFilter.Location = new System.Drawing.Point(1, 51);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(77, 21);
            this.buttonFilter.TabIndex = 14;
            this.buttonFilter.Text = "filter";
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonConfirmPurchase
            // 
            this.buttonConfirmPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonConfirmPurchase.BorderColor = System.Drawing.Color.Purple;
            this.buttonConfirmPurchase.BorderRadius = 30;
            this.buttonConfirmPurchase.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.buttonConfirmPurchase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirmPurchase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirmPurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConfirmPurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConfirmPurchase.FillColor = System.Drawing.SystemColors.Control;
            this.buttonConfirmPurchase.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmPurchase.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirmPurchase.Location = new System.Drawing.Point(661, 547);
            this.buttonConfirmPurchase.Name = "buttonConfirmPurchase";
            this.buttonConfirmPurchase.Size = new System.Drawing.Size(171, 95);
            this.buttonConfirmPurchase.TabIndex = 13;
            this.buttonConfirmPurchase.Text = "Confirm Purchase";
            this.buttonConfirmPurchase.Click += new System.EventHandler(this.buttonConfirmPurchase_Click);
            // 
            // DataGridViewMyCart
            // 
            this.DataGridViewMyCart.AllowUserToResizeColumns = false;
            this.DataGridViewMyCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewMyCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMyCart.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMyCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewMyCart.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewMyCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewMyCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewMyCart.Location = new System.Drawing.Point(18, 113);
            this.DataGridViewMyCart.Name = "DataGridViewMyCart";
            this.DataGridViewMyCart.ReadOnly = true;
            this.DataGridViewMyCart.RowHeadersVisible = false;
            this.DataGridViewMyCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridViewMyCart.Size = new System.Drawing.Size(814, 419);
            this.DataGridViewMyCart.TabIndex = 12;
            this.DataGridViewMyCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewMyCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewMyCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewMyCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewMyCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewMyCart.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewMyCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewMyCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewMyCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewMyCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewMyCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewMyCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewMyCart.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridViewMyCart.ThemeStyle.ReadOnly = true;
            this.DataGridViewMyCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewMyCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewMyCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewMyCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewMyCart.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewMyCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewMyCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewMyCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMyCart_CellClick);
            // 
            // labelMyCart
            // 
            this.labelMyCart.AutoSize = true;
            this.labelMyCart.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyCart.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMyCart.Location = new System.Drawing.Point(364, 38);
            this.labelMyCart.Name = "labelMyCart";
            this.labelMyCart.Size = new System.Drawing.Size(127, 40);
            this.labelMyCart.TabIndex = 9;
            this.labelMyCart.Text = "My Cart";
            // 
            // textBoxTotalBill
            // 
            this.textBoxTotalBill.BorderRadius = 20;
            this.textBoxTotalBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTotalBill.DefaultText = "";
            this.textBoxTotalBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTotalBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTotalBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTotalBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTotalBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTotalBill.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTotalBill.Location = new System.Drawing.Point(179, 585);
            this.textBoxTotalBill.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxTotalBill.Name = "textBoxTotalBill";
            this.textBoxTotalBill.PasswordChar = '\0';
            this.textBoxTotalBill.PlaceholderText = "0";
            this.textBoxTotalBill.ReadOnly = true;
            this.textBoxTotalBill.SelectedText = "";
            this.textBoxTotalBill.Size = new System.Drawing.Size(200, 36);
            this.textBoxTotalBill.TabIndex = 8;
            this.textBoxTotalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRemoveFromCart
            // 
            this.buttonRemoveFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonRemoveFromCart.BorderRadius = 20;
            this.buttonRemoveFromCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRemoveFromCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRemoveFromCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRemoveFromCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRemoveFromCart.FillColor = System.Drawing.SystemColors.Control;
            this.buttonRemoveFromCart.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveFromCart.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveFromCart.Location = new System.Drawing.Point(18, 547);
            this.buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            this.buttonRemoveFromCart.Size = new System.Drawing.Size(149, 63);
            this.buttonRemoveFromCart.TabIndex = 7;
            this.buttonRemoveFromCart.Text = "Remove from Cart";
            this.buttonRemoveFromCart.Click += new System.EventHandler(this.buttonRemoveFromCart_Click);
            // 
            // labelTotalBill
            // 
            this.labelTotalBill.AutoSize = true;
            this.labelTotalBill.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBill.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalBill.Location = new System.Drawing.Point(210, 544);
            this.labelTotalBill.Name = "labelTotalBill";
            this.labelTotalBill.Size = new System.Drawing.Size(137, 38);
            this.labelTotalBill.TabIndex = 5;
            this.labelTotalBill.Text = "Total Bill";
            // 
            // buyerButtonLogOut
            // 
            this.buyerButtonLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.buyerButtonLogOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buyerButtonLogOut.BorderRadius = 20;
            this.buyerButtonLogOut.BorderThickness = 2;
            this.buyerButtonLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyerButtonLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyerButtonLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyerButtonLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyerButtonLogOut.FillColor = System.Drawing.SystemColors.Menu;
            this.buyerButtonLogOut.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerButtonLogOut.ForeColor = System.Drawing.Color.Black;
            this.buyerButtonLogOut.Location = new System.Drawing.Point(1, 598);
            this.buyerButtonLogOut.Name = "buyerButtonLogOut";
            this.buyerButtonLogOut.Size = new System.Drawing.Size(153, 55);
            this.buyerButtonLogOut.TabIndex = 13;
            this.buyerButtonLogOut.Text = "Log Out";
            this.buyerButtonLogOut.Click += new System.EventHandler(this.buyerButtonLogOut_Click);
            // 
            // formMyCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 654);
            this.Controls.Add(this.buyerButtonLogOut);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.buyerButtonPurchaseHistory);
            this.Controls.Add(this.buyerButtonMyCart);
            this.Controls.Add(this.buyerButtonAvailableProducts);
            this.Controls.Add(this.buyerLabelButtonWelcome);
            this.Controls.Add(this.buyerLabelFullname);
            this.Name = "formMyCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMyCart";
            this.Load += new System.EventHandler(this.formMyCart_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMyCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buyerLabelButtonWelcome;
        private System.Windows.Forms.Label buyerLabelFullname;
        private Guna.UI2.WinForms.Guna2Button buyerButtonPurchaseHistory;
        private Guna.UI2.WinForms.Guna2Button buyerButtonMyCart;
        private Guna.UI2.WinForms.Guna2Button buyerButtonAvailableProducts;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewMyCart;
        private System.Windows.Forms.Label labelMyCart;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTotalBill;
        private Guna.UI2.WinForms.Guna2Button buttonRemoveFromCart;
        private System.Windows.Forms.Label labelTotalBill;
        private Guna.UI2.WinForms.Guna2Button buyerButtonLogOut;
        private Guna.UI2.WinForms.Guna2Button buttonConfirmPurchase;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button buttonShowAllProducts;
        private System.Windows.Forms.ComboBox comboBoxFilterByCategory;
        private System.Windows.Forms.Label labelFilterByCategory;
        private Guna.UI2.WinForms.Guna2Button buttonFilter;
    }
}
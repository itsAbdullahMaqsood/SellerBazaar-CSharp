namespace Market_Management_System.Sellerforms
{
    partial class formMyProducts
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
            this.labelButtonWelcome = new Guna.UI2.WinForms.Guna2Button();
            this.labelFullname = new System.Windows.Forms.Label();
            this.buttonMyProducts = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSalesHistory = new Guna.UI2.WinForms.Guna2Button();
            this.buttonShowAll = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonShowAllProducts = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxFilterByCategory = new System.Windows.Forms.ComboBox();
            this.labelFilterByCategory = new System.Windows.Forms.Label();
            this.buttonFilter = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewMyProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelMyProducts = new System.Windows.Forms.Label();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.panelProductListing = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonShowAll.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMyProducts)).BeginInit();
            this.panelProductListing.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelButtonWelcome
            // 
            this.labelButtonWelcome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelButtonWelcome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.labelButtonWelcome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.labelButtonWelcome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.labelButtonWelcome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelButtonWelcome.FillColor = System.Drawing.SystemColors.Menu;
            this.labelButtonWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButtonWelcome.ForeColor = System.Drawing.Color.Black;
            this.labelButtonWelcome.Location = new System.Drawing.Point(-11, -16);
            this.labelButtonWelcome.Name = "labelButtonWelcome";
            this.labelButtonWelcome.Size = new System.Drawing.Size(140, 59);
            this.labelButtonWelcome.TabIndex = 4;
            this.labelButtonWelcome.Text = "Welcome";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.Location = new System.Drawing.Point(-1, 33);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(80, 32);
            this.labelFullname.TabIndex = 3;
            this.labelFullname.Text = "User !";
            // 
            // buttonMyProducts
            // 
            this.buttonMyProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonMyProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMyProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMyProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMyProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMyProducts.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMyProducts.Location = new System.Drawing.Point(0, 180);
            this.buttonMyProducts.Name = "buttonMyProducts";
            this.buttonMyProducts.Size = new System.Drawing.Size(276, 75);
            this.buttonMyProducts.TabIndex = 8;
            this.buttonMyProducts.Text = "My Products";
            this.buttonMyProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonSalesHistory
            // 
            this.buttonSalesHistory.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSalesHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSalesHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSalesHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSalesHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSalesHistory.FillColor = System.Drawing.SystemColors.Control;
            this.buttonSalesHistory.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSalesHistory.Location = new System.Drawing.Point(0, 111);
            this.buttonSalesHistory.Name = "buttonSalesHistory";
            this.buttonSalesHistory.Size = new System.Drawing.Size(276, 72);
            this.buttonSalesHistory.TabIndex = 9;
            this.buttonSalesHistory.Text = "Sales History";
            this.buttonSalesHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonSalesHistory.Click += new System.EventHandler(this.buttonSalesHistory_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonShowAll.Controls.Add(this.guna2Panel2);
            this.buttonShowAll.Controls.Add(this.DataGridViewMyProducts);
            this.buttonShowAll.Controls.Add(this.labelMyProducts);
            this.buttonShowAll.Controls.Add(this.buttonDelete);
            this.buttonShowAll.Controls.Add(this.buttonUpdate);
            this.buttonShowAll.Controls.Add(this.buttonAdd);
            this.buttonShowAll.Location = new System.Drawing.Point(263, 0);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(847, 658);
            this.buttonShowAll.TabIndex = 10;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.buttonShowAllProducts);
            this.guna2Panel2.Controls.Add(this.comboBoxFilterByCategory);
            this.guna2Panel2.Controls.Add(this.labelFilterByCategory);
            this.guna2Panel2.Controls.Add(this.buttonFilter);
            this.guna2Panel2.Location = new System.Drawing.Point(625, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(207, 112);
            this.guna2Panel2.TabIndex = 13;
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
            this.comboBoxFilterByCategory.TabIndex = 5;
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
            // DataGridViewMyProducts
            // 
            this.DataGridViewMyProducts.AllowUserToResizeColumns = false;
            this.DataGridViewMyProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewMyProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMyProducts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMyProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewMyProducts.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewMyProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewMyProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewMyProducts.Location = new System.Drawing.Point(18, 113);
            this.DataGridViewMyProducts.Name = "DataGridViewMyProducts";
            this.DataGridViewMyProducts.ReadOnly = true;
            this.DataGridViewMyProducts.RowHeadersVisible = false;
            this.DataGridViewMyProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridViewMyProducts.Size = new System.Drawing.Size(814, 419);
            this.DataGridViewMyProducts.TabIndex = 12;
            this.DataGridViewMyProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewMyProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewMyProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewMyProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewMyProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewMyProducts.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewMyProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewMyProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewMyProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewMyProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewMyProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewMyProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewMyProducts.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridViewMyProducts.ThemeStyle.ReadOnly = true;
            this.DataGridViewMyProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewMyProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewMyProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewMyProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewMyProducts.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewMyProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewMyProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewMyProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMyProducts_CellClick);
            // 
            // labelMyProducts
            // 
            this.labelMyProducts.AutoSize = true;
            this.labelMyProducts.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMyProducts.Location = new System.Drawing.Point(322, 39);
            this.labelMyProducts.Name = "labelMyProducts";
            this.labelMyProducts.Size = new System.Drawing.Size(191, 40);
            this.labelMyProducts.TabIndex = 9;
            this.labelMyProducts.Text = "My Products";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonDelete.BorderRadius = 20;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.FillColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(710, 565);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 63);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonUpdate.BorderRadius = 20;
            this.buttonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUpdate.FillColor = System.Drawing.SystemColors.Control;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(165, 565);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 63);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonAdd.BorderRadius = 20;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(18, 565);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 63);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonLogOut.BorderRadius = 20;
            this.buttonLogOut.BorderThickness = 2;
            this.buttonLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogOut.FillColor = System.Drawing.SystemColors.Menu;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.Black;
            this.buttonLogOut.Location = new System.Drawing.Point(1, 598);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(153, 55);
            this.buttonLogOut.TabIndex = 11;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panelProductListing
            // 
            this.panelProductListing.Controls.Add(this.textBoxCategory);
            this.panelProductListing.Controls.Add(this.textBoxQuantity);
            this.panelProductListing.Controls.Add(this.textBoxPrice);
            this.panelProductListing.Controls.Add(this.textBoxName);
            this.panelProductListing.Controls.Add(this.labelCategory);
            this.panelProductListing.Controls.Add(this.labelQuantity);
            this.panelProductListing.Controls.Add(this.labelPrice);
            this.panelProductListing.Controls.Add(this.labelName);
            this.panelProductListing.Location = new System.Drawing.Point(5, 277);
            this.panelProductListing.Name = "panelProductListing";
            this.panelProductListing.Size = new System.Drawing.Size(253, 268);
            this.panelProductListing.TabIndex = 12;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCategory.DefaultText = "";
            this.textBoxCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCategory.Location = new System.Drawing.Point(111, 210);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.PasswordChar = '\0';
            this.textBoxCategory.PlaceholderText = "";
            this.textBoxCategory.SelectedText = "";
            this.textBoxCategory.Size = new System.Drawing.Size(142, 36);
            this.textBoxCategory.TabIndex = 4;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQuantity.DefaultText = "";
            this.textBoxQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxQuantity.Location = new System.Drawing.Point(111, 140);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.PasswordChar = '\0';
            this.textBoxQuantity.PlaceholderText = "";
            this.textBoxQuantity.SelectedText = "";
            this.textBoxQuantity.Size = new System.Drawing.Size(142, 36);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrice.DefaultText = "";
            this.textBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrice.Location = new System.Drawing.Point(111, 74);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.PasswordChar = '\0';
            this.textBoxPrice.PlaceholderText = "";
            this.textBoxPrice.SelectedText = "";
            this.textBoxPrice.Size = new System.Drawing.Size(142, 36);
            this.textBoxPrice.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(111, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(142, 36);
            this.textBoxName.TabIndex = 0;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(-6, 210);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(118, 32);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(-5, 140);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(113, 32);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(-4, 78);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(71, 32);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(-5, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 32);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // formMyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 654);
            this.Controls.Add(this.panelProductListing);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonSalesHistory);
            this.Controls.Add(this.buttonMyProducts);
            this.Controls.Add(this.labelButtonWelcome);
            this.Controls.Add(this.labelFullname);
            this.Name = "formMyProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMyProducts";
            this.Load += new System.EventHandler(this.formMyProducts_Load);
            this.buttonShowAll.ResumeLayout(false);
            this.buttonShowAll.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMyProducts)).EndInit();
            this.panelProductListing.ResumeLayout(false);
            this.panelProductListing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button labelButtonWelcome;
        private System.Windows.Forms.Label labelFullname;
        private Guna.UI2.WinForms.Guna2Button buttonMyProducts;
        private Guna.UI2.WinForms.Guna2Button buttonSalesHistory;
        private Guna.UI2.WinForms.Guna2Panel buttonShowAll;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewMyProducts;
        private System.Windows.Forms.Label labelMyProducts;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button buttonLogOut;
        private Guna.UI2.WinForms.Guna2Panel panelProductListing;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCategory;
        private Guna.UI2.WinForms.Guna2TextBox textBoxQuantity;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPrice;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.ComboBox comboBoxFilterByCategory;
        private System.Windows.Forms.Label labelFilterByCategory;
        private Guna.UI2.WinForms.Guna2Button buttonFilter;
        private Guna.UI2.WinForms.Guna2Button buttonShowAllProducts;
    }
}
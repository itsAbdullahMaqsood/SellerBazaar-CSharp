namespace Market_Management_System.Models
{
    partial class formViewSeller
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buyerLabelButtonWelcome = new Guna.UI2.WinForms.Guna2Button();
            this.buyerLabelFullname = new System.Windows.Forms.Label();
            this.buttonAllBuyers = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAllSellers = new Guna.UI2.WinForms.Guna2Button();
            this.buttonTotalSales = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonShowAllProducts = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxFilterByCategory = new System.Windows.Forms.ComboBox();
            this.labelFilterByName = new System.Windows.Forms.Label();
            this.buttonFilter = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewAllSellers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelListOfAllSellers = new System.Windows.Forms.Label();
            this.buttonUnban = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBan = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllSellers)).BeginInit();
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
            this.buyerLabelButtonWelcome.Location = new System.Drawing.Point(-11, -16);
            this.buyerLabelButtonWelcome.Name = "buyerLabelButtonWelcome";
            this.buyerLabelButtonWelcome.Size = new System.Drawing.Size(140, 59);
            this.buyerLabelButtonWelcome.TabIndex = 4;
            this.buyerLabelButtonWelcome.Text = "Welcome";
            // 
            // buyerLabelFullname
            // 
            this.buyerLabelFullname.AutoSize = true;
            this.buyerLabelFullname.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerLabelFullname.Location = new System.Drawing.Point(-1, 33);
            this.buyerLabelFullname.Name = "buyerLabelFullname";
            this.buyerLabelFullname.Size = new System.Drawing.Size(105, 32);
            this.buyerLabelFullname.TabIndex = 3;
            this.buyerLabelFullname.Text = "Admin !";
            // 
            // buttonAllBuyers
            // 
            this.buttonAllBuyers.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAllBuyers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAllBuyers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAllBuyers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAllBuyers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAllBuyers.FillColor = System.Drawing.SystemColors.Control;
            this.buttonAllBuyers.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllBuyers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAllBuyers.Location = new System.Drawing.Point(-1, 183);
            this.buttonAllBuyers.Name = "buttonAllBuyers";
            this.buttonAllBuyers.Size = new System.Drawing.Size(276, 72);
            this.buttonAllBuyers.TabIndex = 13;
            this.buttonAllBuyers.Text = "All Buyers";
            this.buttonAllBuyers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonAllBuyers.Click += new System.EventHandler(this.buttonAllBuyers_Click);
            // 
            // buttonAllSellers
            // 
            this.buttonAllSellers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonAllSellers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAllSellers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAllSellers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAllSellers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAllSellers.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllSellers.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAllSellers.Location = new System.Drawing.Point(-1, 114);
            this.buttonAllSellers.Name = "buttonAllSellers";
            this.buttonAllSellers.Size = new System.Drawing.Size(276, 75);
            this.buttonAllSellers.TabIndex = 12;
            this.buttonAllSellers.Text = "All Sellers";
            this.buttonAllSellers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonTotalSales
            // 
            this.buttonTotalSales.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTotalSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonTotalSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonTotalSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonTotalSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonTotalSales.FillColor = System.Drawing.SystemColors.Control;
            this.buttonTotalSales.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotalSales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTotalSales.Location = new System.Drawing.Point(-1, 259);
            this.buttonTotalSales.Name = "buttonTotalSales";
            this.buttonTotalSales.Size = new System.Drawing.Size(276, 72);
            this.buttonTotalSales.TabIndex = 13;
            this.buttonTotalSales.Text = "Total Sales";
            this.buttonTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonTotalSales.Click += new System.EventHandler(this.buttonTotalSales_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.DataGridViewAllSellers);
            this.guna2Panel1.Controls.Add(this.labelListOfAllSellers);
            this.guna2Panel1.Controls.Add(this.buttonUnban);
            this.guna2Panel1.Controls.Add(this.buttonBan);
            this.guna2Panel1.Location = new System.Drawing.Point(263, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(847, 658);
            this.guna2Panel1.TabIndex = 14;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.buttonShowAllProducts);
            this.guna2Panel2.Controls.Add(this.comboBoxFilterByCategory);
            this.guna2Panel2.Controls.Add(this.labelFilterByName);
            this.guna2Panel2.Controls.Add(this.buttonFilter);
            this.guna2Panel2.Location = new System.Drawing.Point(625, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(207, 112);
            this.guna2Panel2.TabIndex = 14;
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
            // labelFilterByName
            // 
            this.labelFilterByName.AutoSize = true;
            this.labelFilterByName.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterByName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFilterByName.Location = new System.Drawing.Point(41, 23);
            this.labelFilterByName.Name = "labelFilterByName";
            this.labelFilterByName.Size = new System.Drawing.Size(126, 21);
            this.labelFilterByName.TabIndex = 15;
            this.labelFilterByName.Text = "Filter By Name";
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
            // DataGridViewAllSellers
            // 
            this.DataGridViewAllSellers.AllowUserToResizeColumns = false;
            this.DataGridViewAllSellers.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.DataGridViewAllSellers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.DataGridViewAllSellers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAllSellers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.DataGridViewAllSellers.ColumnHeadersHeight = 30;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewAllSellers.DefaultCellStyle = dataGridViewCellStyle21;
            this.DataGridViewAllSellers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewAllSellers.Location = new System.Drawing.Point(18, 113);
            this.DataGridViewAllSellers.Name = "DataGridViewAllSellers";
            this.DataGridViewAllSellers.ReadOnly = true;
            this.DataGridViewAllSellers.RowHeadersVisible = false;
            this.DataGridViewAllSellers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridViewAllSellers.Size = new System.Drawing.Size(814, 419);
            this.DataGridViewAllSellers.TabIndex = 12;
            this.DataGridViewAllSellers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewAllSellers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewAllSellers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewAllSellers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewAllSellers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewAllSellers.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridViewAllSellers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewAllSellers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewAllSellers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewAllSellers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewAllSellers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewAllSellers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewAllSellers.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridViewAllSellers.ThemeStyle.ReadOnly = true;
            this.DataGridViewAllSellers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewAllSellers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewAllSellers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewAllSellers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewAllSellers.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewAllSellers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewAllSellers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewAllSellers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAllSellers_CellClick);
            // 
            // labelListOfAllSellers
            // 
            this.labelListOfAllSellers.AutoSize = true;
            this.labelListOfAllSellers.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListOfAllSellers.ForeColor = System.Drawing.SystemColors.Control;
            this.labelListOfAllSellers.Location = new System.Drawing.Point(302, 38);
            this.labelListOfAllSellers.Name = "labelListOfAllSellers";
            this.labelListOfAllSellers.Size = new System.Drawing.Size(242, 40);
            this.labelListOfAllSellers.TabIndex = 9;
            this.labelListOfAllSellers.Text = "List of All Sellers";
            // 
            // buttonUnban
            // 
            this.buttonUnban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonUnban.BorderRadius = 20;
            this.buttonUnban.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUnban.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUnban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUnban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUnban.FillColor = System.Drawing.SystemColors.Control;
            this.buttonUnban.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnban.ForeColor = System.Drawing.Color.Black;
            this.buttonUnban.Location = new System.Drawing.Point(710, 565);
            this.buttonUnban.Name = "buttonUnban";
            this.buttonUnban.Size = new System.Drawing.Size(122, 63);
            this.buttonUnban.TabIndex = 7;
            this.buttonUnban.Text = "Unban";
            this.buttonUnban.Click += new System.EventHandler(this.buttonUnban_Click);
            // 
            // buttonBan
            // 
            this.buttonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonBan.BorderRadius = 20;
            this.buttonBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBan.FillColor = System.Drawing.SystemColors.Control;
            this.buttonBan.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBan.ForeColor = System.Drawing.Color.Black;
            this.buttonBan.Location = new System.Drawing.Point(18, 565);
            this.buttonBan.Name = "buttonBan";
            this.buttonBan.Size = new System.Drawing.Size(122, 63);
            this.buttonBan.TabIndex = 7;
            this.buttonBan.Text = "Ban";
            this.buttonBan.Click += new System.EventHandler(this.buttonBan_Click);
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
            this.buttonLogOut.TabIndex = 15;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.Click += new System.EventHandler(this.buyerButtonLogOut_Click);
            // 
            // formViewSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 654);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.buttonTotalSales);
            this.Controls.Add(this.buttonAllBuyers);
            this.Controls.Add(this.buttonAllSellers);
            this.Controls.Add(this.buyerLabelButtonWelcome);
            this.Controls.Add(this.buyerLabelFullname);
            this.Name = "formViewSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formViewSeller";
            this.Load += new System.EventHandler(this.formViewSeller_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllSellers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buyerLabelButtonWelcome;
        private System.Windows.Forms.Label buyerLabelFullname;
        private Guna.UI2.WinForms.Guna2Button buttonAllBuyers;
        private Guna.UI2.WinForms.Guna2Button buttonAllSellers;
        private Guna.UI2.WinForms.Guna2Button buttonTotalSales;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewAllSellers;
        private System.Windows.Forms.Label labelListOfAllSellers;
        private Guna.UI2.WinForms.Guna2Button buttonLogOut;
        private Guna.UI2.WinForms.Guna2Button buttonUnban;
        private Guna.UI2.WinForms.Guna2Button buttonBan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button buttonShowAllProducts;
        private System.Windows.Forms.ComboBox comboBoxFilterByCategory;
        private System.Windows.Forms.Label labelFilterByName;
        private Guna.UI2.WinForms.Guna2Button buttonFilter;
    }
}
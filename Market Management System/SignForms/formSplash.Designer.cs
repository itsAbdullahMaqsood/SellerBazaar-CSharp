namespace Market_Management_System
{
    partial class formSplash
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
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.progressbarSplash = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.labelEcommerceMarketApplication = new System.Windows.Forms.Label();
            this.labelMadebyabdullahmaqsood = new System.Windows.Forms.Label();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(1, 292);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(727, 282);
            this.guna2CircleButton1.TabIndex = 0;
            // 
            // progressbarSplash
            // 
            this.progressbarSplash.BackColor = System.Drawing.SystemColors.Control;
            this.progressbarSplash.FillColor = System.Drawing.Color.DarkOrange;
            this.progressbarSplash.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressbarSplash.ForeColor = System.Drawing.Color.White;
            this.progressbarSplash.Location = new System.Drawing.Point(295, 120);
            this.progressbarSplash.Minimum = 0;
            this.progressbarSplash.Name = "progressbarSplash";
            this.progressbarSplash.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressbarSplash.Size = new System.Drawing.Size(130, 130);
            this.progressbarSplash.TabIndex = 1;
            this.progressbarSplash.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // labelEcommerceMarketApplication
            // 
            this.labelEcommerceMarketApplication.AutoSize = true;
            this.labelEcommerceMarketApplication.BackColor = System.Drawing.SystemColors.Control;
            this.labelEcommerceMarketApplication.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEcommerceMarketApplication.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEcommerceMarketApplication.Location = new System.Drawing.Point(77, 32);
            this.labelEcommerceMarketApplication.Name = "labelEcommerceMarketApplication";
            this.labelEcommerceMarketApplication.Size = new System.Drawing.Size(570, 50);
            this.labelEcommerceMarketApplication.TabIndex = 2;
            this.labelEcommerceMarketApplication.Text = "Ecommerce Market Application";
            // 
            // labelMadebyabdullahmaqsood
            // 
            this.labelMadebyabdullahmaqsood.AutoSize = true;
            this.labelMadebyabdullahmaqsood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labelMadebyabdullahmaqsood.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMadebyabdullahmaqsood.ForeColor = System.Drawing.Color.Honeydew;
            this.labelMadebyabdullahmaqsood.Location = new System.Drawing.Point(462, 383);
            this.labelMadebyabdullahmaqsood.Name = "labelMadebyabdullahmaqsood";
            this.labelMadebyabdullahmaqsood.Size = new System.Drawing.Size(236, 20);
            this.labelMadebyabdullahmaqsood.TabIndex = 3;
            this.labelMadebyabdullahmaqsood.Text = "© Made By itsAbdullahMaqsood";
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 412);
            this.Controls.Add(this.labelMadebyabdullahmaqsood);
            this.Controls.Add(this.labelEcommerceMarketApplication);
            this.Controls.Add(this.progressbarSplash);
            this.Controls.Add(this.guna2CircleButton1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Form";
            this.Load += new System.EventHandler(this.formSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressbarSplash;
        private System.Windows.Forms.Label labelEcommerceMarketApplication;
        private System.Windows.Forms.Label labelMadebyabdullahmaqsood;
        private System.Windows.Forms.Timer timerSplash;
    }
}
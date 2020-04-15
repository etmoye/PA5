namespace etmoye___pa5
{
    partial class formMain
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
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnNewListing = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReports.Location = new System.Drawing.Point(24, 567);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(275, 85);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTransaction.Location = new System.Drawing.Point(24, 453);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(275, 85);
            this.btnTransaction.TabIndex = 3;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnNewListing
            // 
            this.btnNewListing.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNewListing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewListing.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewListing.Location = new System.Drawing.Point(24, 225);
            this.btnNewListing.Name = "btnNewListing";
            this.btnNewListing.Size = new System.Drawing.Size(275, 85);
            this.btnNewListing.TabIndex = 4;
            this.btnNewListing.Text = "New Listing";
            this.btnNewListing.UseVisualStyleBackColor = false;
            this.btnNewListing.Click += new System.EventHandler(this.btnNewListing_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(894, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 49);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 40);
            this.textBox1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnListings);
            this.panel1.Controls.Add(this.btnNewListing);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 856);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnListings
            // 
            this.btnListings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListings.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListings.Location = new System.Drawing.Point(24, 341);
            this.btnListings.Name = "btnListings";
            this.btnListings.Size = new System.Drawing.Size(275, 85);
            this.btnListings.TabIndex = 5;
            this.btnListings.Text = "Listings";
            this.btnListings.UseVisualStyleBackColor = false;
            this.btnListings.Click += new System.EventHandler(this.btnListings_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(299, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 151);
            this.panel2.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.Location = new System.Drawing.Point(49, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(518, 65);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "RentMyPlace.com";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::etmoye___pa5.Properties.Resources.bryant_denny1;
            this.pictureBox1.Location = new System.Drawing.Point(252, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1204, 774);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1435, 856);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentMyPlace";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnNewListing;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListings;
    }
}


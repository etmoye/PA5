namespace etmoye___pa5
{
    partial class formListings
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
            this.txtboxListingID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.txtboxEndDate = new System.Windows.Forms.TextBox();
            this.labelRentAmount = new System.Windows.Forms.Label();
            this.txtboxRentAmount = new System.Windows.Forms.TextBox();
            this.labelCheckout = new System.Windows.Forms.Label();
            this.txtboxCheckout = new System.Windows.Forms.TextBox();
            this.labelOwnerEmail = new System.Windows.Forms.Label();
            this.txtboxOwnerEmail = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listboxListings = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtboxListingID
            // 
            this.txtboxListingID.Location = new System.Drawing.Point(564, 82);
            this.txtboxListingID.Name = "txtboxListingID";
            this.txtboxListingID.Size = new System.Drawing.Size(235, 35);
            this.txtboxListingID.TabIndex = 0;
            this.txtboxListingID.TextChanged += new System.EventHandler(this.txtboxListingID_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial", 12F);
            this.labelID.Location = new System.Drawing.Point(443, 85);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(112, 27);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Listing ID";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(456, 141);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(100, 27);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(564, 140);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(564, 35);
            this.txtboxAddress.TabIndex = 3;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(444, 198);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(113, 27);
            this.labelEndDate.TabIndex = 4;
            this.labelEndDate.Text = "End Date";
            // 
            // txtboxEndDate
            // 
            this.txtboxEndDate.Location = new System.Drawing.Point(564, 197);
            this.txtboxEndDate.Name = "txtboxEndDate";
            this.txtboxEndDate.Size = new System.Drawing.Size(564, 35);
            this.txtboxEndDate.TabIndex = 5;
            // 
            // labelRentAmount
            // 
            this.labelRentAmount.AutoSize = true;
            this.labelRentAmount.Location = new System.Drawing.Point(385, 254);
            this.labelRentAmount.Name = "labelRentAmount";
            this.labelRentAmount.Size = new System.Drawing.Size(171, 27);
            this.labelRentAmount.TabIndex = 6;
            this.labelRentAmount.Text = "Rental Amount";
            // 
            // txtboxRentAmount
            // 
            this.txtboxRentAmount.Location = new System.Drawing.Point(564, 254);
            this.txtboxRentAmount.Name = "txtboxRentAmount";
            this.txtboxRentAmount.Size = new System.Drawing.Size(564, 35);
            this.txtboxRentAmount.TabIndex = 7;
            // 
            // labelCheckout
            // 
            this.labelCheckout.AutoSize = true;
            this.labelCheckout.Location = new System.Drawing.Point(385, 311);
            this.labelCheckout.Name = "labelCheckout";
            this.labelCheckout.Size = new System.Drawing.Size(171, 27);
            this.labelCheckout.TabIndex = 8;
            this.labelCheckout.Text = "Checkout Date";
            // 
            // txtboxCheckout
            // 
            this.txtboxCheckout.Location = new System.Drawing.Point(564, 312);
            this.txtboxCheckout.Name = "txtboxCheckout";
            this.txtboxCheckout.Size = new System.Drawing.Size(564, 35);
            this.txtboxCheckout.TabIndex = 9;
            // 
            // labelOwnerEmail
            // 
            this.labelOwnerEmail.AutoSize = true;
            this.labelOwnerEmail.Location = new System.Drawing.Point(407, 367);
            this.labelOwnerEmail.Name = "labelOwnerEmail";
            this.labelOwnerEmail.Size = new System.Drawing.Size(150, 27);
            this.labelOwnerEmail.TabIndex = 10;
            this.labelOwnerEmail.Text = "Owner Email";
            // 
            // txtboxOwnerEmail
            // 
            this.txtboxOwnerEmail.Location = new System.Drawing.Point(564, 369);
            this.txtboxOwnerEmail.Name = "txtboxOwnerEmail";
            this.txtboxOwnerEmail.Size = new System.Drawing.Size(564, 35);
            this.txtboxOwnerEmail.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(412, 448);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 66);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(598, 448);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(170, 66);
            this.btnRent.TabIndex = 13;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(971, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 66);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(784, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 66);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listboxListings
            // 
            this.listboxListings.FormattingEnabled = true;
            this.listboxListings.ItemHeight = 27;
            this.listboxListings.Location = new System.Drawing.Point(30, 60);
            this.listboxListings.Name = "listboxListings";
            this.listboxListings.Size = new System.Drawing.Size(319, 463);
            this.listboxListings.TabIndex = 16;
            this.listboxListings.SelectedIndexChanged += new System.EventHandler(this.listboxListings_SelectedIndexChanged);
            // 
            // formListings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 620);
            this.Controls.Add(this.listboxListings);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtboxOwnerEmail);
            this.Controls.Add(this.labelOwnerEmail);
            this.Controls.Add(this.txtboxCheckout);
            this.Controls.Add(this.labelCheckout);
            this.Controls.Add(this.txtboxRentAmount);
            this.Controls.Add(this.labelRentAmount);
            this.Controls.Add(this.txtboxEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtboxListingID);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formListings";
            this.ShowIcon = false;
            this.Text = "Listings";
            this.Load += new System.EventHandler(this.formListings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxListingID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.TextBox txtboxEndDate;
        private System.Windows.Forms.Label labelRentAmount;
        private System.Windows.Forms.TextBox txtboxRentAmount;
        private System.Windows.Forms.Label labelCheckout;
        private System.Windows.Forms.TextBox txtboxCheckout;
        private System.Windows.Forms.Label labelOwnerEmail;
        private System.Windows.Forms.TextBox txtboxOwnerEmail;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listboxListings;
    }
}
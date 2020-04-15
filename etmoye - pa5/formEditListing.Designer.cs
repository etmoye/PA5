namespace etmoye___pa5
{
    partial class formEditListing
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
            this.txtboxOwnerEmail = new System.Windows.Forms.TextBox();
            this.labelOwnerEmail = new System.Windows.Forms.Label();
            this.txtboxCheckout = new System.Windows.Forms.TextBox();
            this.labelCheckout = new System.Windows.Forms.Label();
            this.txtboxRentAmount = new System.Windows.Forms.TextBox();
            this.labelRentAmount = new System.Windows.Forms.Label();
            this.txtboxEndDate = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtboxListingID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxOwnerEmail
            // 
            this.txtboxOwnerEmail.Location = new System.Drawing.Point(205, 335);
            this.txtboxOwnerEmail.Name = "txtboxOwnerEmail";
            this.txtboxOwnerEmail.Size = new System.Drawing.Size(564, 35);
            this.txtboxOwnerEmail.TabIndex = 23;
            // 
            // labelOwnerEmail
            // 
            this.labelOwnerEmail.AutoSize = true;
            this.labelOwnerEmail.Location = new System.Drawing.Point(48, 333);
            this.labelOwnerEmail.Name = "labelOwnerEmail";
            this.labelOwnerEmail.Size = new System.Drawing.Size(150, 27);
            this.labelOwnerEmail.TabIndex = 22;
            this.labelOwnerEmail.Text = "Owner Email";
            // 
            // txtboxCheckout
            // 
            this.txtboxCheckout.Location = new System.Drawing.Point(205, 278);
            this.txtboxCheckout.Name = "txtboxCheckout";
            this.txtboxCheckout.Size = new System.Drawing.Size(564, 35);
            this.txtboxCheckout.TabIndex = 21;
            // 
            // labelCheckout
            // 
            this.labelCheckout.AutoSize = true;
            this.labelCheckout.Location = new System.Drawing.Point(26, 277);
            this.labelCheckout.Name = "labelCheckout";
            this.labelCheckout.Size = new System.Drawing.Size(171, 27);
            this.labelCheckout.TabIndex = 20;
            this.labelCheckout.Text = "Checkout Date";
            // 
            // txtboxRentAmount
            // 
            this.txtboxRentAmount.Location = new System.Drawing.Point(205, 220);
            this.txtboxRentAmount.Name = "txtboxRentAmount";
            this.txtboxRentAmount.Size = new System.Drawing.Size(564, 35);
            this.txtboxRentAmount.TabIndex = 19;
            // 
            // labelRentAmount
            // 
            this.labelRentAmount.AutoSize = true;
            this.labelRentAmount.Location = new System.Drawing.Point(26, 220);
            this.labelRentAmount.Name = "labelRentAmount";
            this.labelRentAmount.Size = new System.Drawing.Size(171, 27);
            this.labelRentAmount.TabIndex = 18;
            this.labelRentAmount.Text = "Rental Amount";
            // 
            // txtboxEndDate
            // 
            this.txtboxEndDate.Location = new System.Drawing.Point(205, 163);
            this.txtboxEndDate.Name = "txtboxEndDate";
            this.txtboxEndDate.Size = new System.Drawing.Size(564, 35);
            this.txtboxEndDate.TabIndex = 17;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(85, 164);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(113, 27);
            this.labelEndDate.TabIndex = 16;
            this.labelEndDate.Text = "End Date";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(205, 106);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(564, 35);
            this.txtboxAddress.TabIndex = 15;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(97, 107);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(100, 27);
            this.labelAddress.TabIndex = 14;
            this.labelAddress.Text = "Address";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial", 12F);
            this.labelID.Location = new System.Drawing.Point(84, 51);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(112, 27);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "Listing ID";
            // 
            // txtboxListingID
            // 
            this.txtboxListingID.Location = new System.Drawing.Point(205, 48);
            this.txtboxListingID.Name = "txtboxListingID";
            this.txtboxListingID.Size = new System.Drawing.Size(235, 35);
            this.txtboxListingID.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(599, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 66);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formEditListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 525);
            this.Controls.Add(this.btnSave);
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
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEditListing";
            this.ShowIcon = false;
            this.Text = "Edit Listing";
            this.Load += new System.EventHandler(this.formEditListing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxOwnerEmail;
        private System.Windows.Forms.Label labelOwnerEmail;
        private System.Windows.Forms.TextBox txtboxCheckout;
        private System.Windows.Forms.Label labelCheckout;
        private System.Windows.Forms.TextBox txtboxRentAmount;
        private System.Windows.Forms.Label labelRentAmount;
        private System.Windows.Forms.TextBox txtboxEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtboxListingID;
        private System.Windows.Forms.Button btnSave;
    }
}
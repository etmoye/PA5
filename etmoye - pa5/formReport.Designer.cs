namespace etmoye___pa5
{
    partial class formReport
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
            this.radiobtnIndCust = new System.Windows.Forms.RadioButton();
            this.radiobtnHistCust = new System.Windows.Forms.RadioButton();
            this.radiobtnHistRev = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // radiobtnIndCust
            // 
            this.radiobtnIndCust.AutoSize = true;
            this.radiobtnIndCust.Location = new System.Drawing.Point(87, 54);
            this.radiobtnIndCust.Name = "radiobtnIndCust";
            this.radiobtnIndCust.Size = new System.Drawing.Size(329, 31);
            this.radiobtnIndCust.TabIndex = 0;
            this.radiobtnIndCust.TabStop = true;
            this.radiobtnIndCust.Text = "Individual Customer Report";
            this.radiobtnIndCust.UseVisualStyleBackColor = true;
            // 
            // radiobtnHistCust
            // 
            this.radiobtnHistCust.AutoSize = true;
            this.radiobtnHistCust.Location = new System.Drawing.Point(458, 54);
            this.radiobtnHistCust.Name = "radiobtnHistCust";
            this.radiobtnHistCust.Size = new System.Drawing.Size(325, 31);
            this.radiobtnHistCust.TabIndex = 1;
            this.radiobtnHistCust.TabStop = true;
            this.radiobtnHistCust.Text = "Historical Customer Report";
            this.radiobtnHistCust.UseVisualStyleBackColor = true;
            // 
            // radiobtnHistRev
            // 
            this.radiobtnHistRev.AutoSize = true;
            this.radiobtnHistRev.Location = new System.Drawing.Point(829, 54);
            this.radiobtnHistRev.Name = "radiobtnHistRev";
            this.radiobtnHistRev.Size = new System.Drawing.Size(316, 31);
            this.radiobtnHistRev.TabIndex = 2;
            this.radiobtnHistRev.TabStop = true;
            this.radiobtnHistRev.Text = "Historical Revenue Report";
            this.radiobtnHistRev.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(997, 623);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 67);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Report";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(153, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(954, 423);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.formReport_Load);
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 737);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radiobtnHistRev);
            this.Controls.Add(this.radiobtnHistCust);
            this.Controls.Add(this.radiobtnIndCust);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formReport";
            this.ShowIcon = false;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.formReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtnIndCust;
        private System.Windows.Forms.RadioButton radiobtnHistCust;
        private System.Windows.Forms.RadioButton radiobtnHistRev;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
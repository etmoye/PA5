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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.richTextBoxHistCust = new System.Windows.Forms.RichTextBox();
            this.richTextBoxHistRev = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // radiobtnIndCust
            // 
            this.radiobtnIndCust.AutoSize = true;
            this.radiobtnIndCust.Location = new System.Drawing.Point(841, 182);
            this.radiobtnIndCust.Name = "radiobtnIndCust";
            this.radiobtnIndCust.Size = new System.Drawing.Size(329, 31);
            this.radiobtnIndCust.TabIndex = 0;
            this.radiobtnIndCust.TabStop = true;
            this.radiobtnIndCust.Text = "Individual Customer Report";
            this.radiobtnIndCust.UseVisualStyleBackColor = true;
            this.radiobtnIndCust.CheckedChanged += new System.EventHandler(this.radiobtnIndCust_CheckedChanged);
            // 
            // radiobtnHistCust
            // 
            this.radiobtnHistCust.AutoSize = true;
            this.radiobtnHistCust.Location = new System.Drawing.Point(841, 319);
            this.radiobtnHistCust.Name = "radiobtnHistCust";
            this.radiobtnHistCust.Size = new System.Drawing.Size(325, 31);
            this.radiobtnHistCust.TabIndex = 1;
            this.radiobtnHistCust.TabStop = true;
            this.radiobtnHistCust.Text = "Historical Customer Report";
            this.radiobtnHistCust.UseVisualStyleBackColor = true;
            this.radiobtnHistCust.CheckedChanged += new System.EventHandler(this.radiobtnHistCust_CheckedChanged);
            // 
            // radiobtnHistRev
            // 
            this.radiobtnHistRev.AutoSize = true;
            this.radiobtnHistRev.Location = new System.Drawing.Point(841, 446);
            this.radiobtnHistRev.Name = "radiobtnHistRev";
            this.radiobtnHistRev.Size = new System.Drawing.Size(316, 31);
            this.radiobtnHistRev.TabIndex = 2;
            this.radiobtnHistRev.TabStop = true;
            this.radiobtnHistRev.Text = "Historical Revenue Report";
            this.radiobtnHistRev.UseVisualStyleBackColor = true;
            this.radiobtnHistRev.CheckedChanged += new System.EventHandler(this.radiobtnHistRev_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(87, 153);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(677, 521);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.formReport_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 35);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(596, 67);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(118, 33);
            this.Search.TabIndex = 7;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // richTextBoxHistCust
            // 
            this.richTextBoxHistCust.Location = new System.Drawing.Point(87, 153);
            this.richTextBoxHistCust.Name = "richTextBoxHistCust";
            this.richTextBoxHistCust.Size = new System.Drawing.Size(677, 521);
            this.richTextBoxHistCust.TabIndex = 8;
            this.richTextBoxHistCust.Text = "";
            this.richTextBoxHistCust.Visible = false;
            // 
            // richTextBoxHistRev
            // 
            this.richTextBoxHistRev.Location = new System.Drawing.Point(87, 153);
            this.richTextBoxHistRev.Name = "richTextBoxHistRev";
            this.richTextBoxHistRev.Size = new System.Drawing.Size(677, 521);
            this.richTextBoxHistRev.TabIndex = 9;
            this.richTextBoxHistRev.Text = "";
            this.richTextBoxHistRev.Visible = false;
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 737);
            this.Controls.Add(this.richTextBoxHistRev);
            this.Controls.Add(this.richTextBoxHistCust);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radiobtnHistRev);
            this.Controls.Add(this.radiobtnHistCust);
            this.Controls.Add(this.radiobtnIndCust);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.formReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtnIndCust;
        private System.Windows.Forms.RadioButton radiobtnHistCust;
        private System.Windows.Forms.RadioButton radiobtnHistRev;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RichTextBox richTextBoxHistCust;
        private System.Windows.Forms.RichTextBox richTextBoxHistRev;
    }
}
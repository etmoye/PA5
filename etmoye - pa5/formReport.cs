using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace etmoye___pa5
{

    public partial class formReport : Form
    {
        Transaction[] viewTransaction;
        TransactionUtilities transactionUtils;
        TransactionReports allReports;

        public formReport()
        {
            InitializeComponent();
         
            viewTransaction = new Transaction[100];
            transactionUtils = new TransactionUtilities(viewTransaction);
            allReports = new TransactionReports(viewTransaction);
        }

        
        private void formReport_Load(object sender, EventArgs e)
        {

            allReports.RevenueReport();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.Text = File.ReadAllText("report.txt");
            //richTextBox1.Text = "hello please work";
            //this.Controls.Add(richTextBox1);
     
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radiobtnIndCust_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBoxHistCust.Visible = false;
            richTextBoxHistRev.Visible = false;
           
                       
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchVal = textBox1.Text;
            allReports.ByRenterEmail(searchVal);

            //allReports.HistoricalCustomerRental(searchVal);

            if (radiobtnIndCust.Checked == true)
            {
                richTextBox1.Text = File.ReadAllText("IndividualCustomer.txt");
            }
        }

        private void radiobtnHistCust_CheckedChanged(object sender, EventArgs e)
        {

            allReports.HistoricalCustomerRental();
            if(radiobtnHistCust.Checked == true)
            {
                richTextBox1.Visible = false;
                richTextBoxHistCust.Visible = true;
                richTextBoxHistRev.Visible = false;
                richTextBoxHistCust.Text = File.ReadAllText("HistoricalCustomer.txt");
            }
        }

        private void radiobtnHistRev_CheckedChanged(object sender, EventArgs e)
        {
            allReports.RevenueReport();
            if (radiobtnHistRev.Checked == true)
            {
                richTextBox1.Visible = false;
                richTextBoxHistRev.Visible = true;
                richTextBoxHistCust.Visible = false;
                richTextBoxHistRev.Text = File.ReadAllText("RevenueReport.txt");
            }
        }
    }
}

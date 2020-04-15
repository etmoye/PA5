using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etmoye___pa5
{

    public partial class formReport : Form
    {
        

        public formReport()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Report saved - not actually saved yet", "Save", MessageBoxButtons.OK);
            
        }

        private void formReport_Load(object sender, EventArgs e)
        {

            richTextBox1.Text = "hello please work";
           
           // this.Controls.Add(richTextBox1);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            //richTextBox1.Text = "hello please work";
            //this.Controls.Add(richTextBox1);
     
        }
    }
}

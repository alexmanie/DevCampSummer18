
using QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.textBox1.LostFocus += TextBox1_LostFocus;
        }

        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            object data = Utils.FileUtils.ReadSampleDataAsObject();
            var sampleData = SampleData.FromJson(data.ToString());
        }
    }
}

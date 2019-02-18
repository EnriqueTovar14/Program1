using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double weightE, weightM;
                weightE = double.Parse(textBox1.Text);
                weightM = weightE / 9.81 * 3.711;
                textBox2.Text = weightM.ToString();
                textBox2.Text = String.Format("{0:0.000}", weightM);
            }

            catch { 
            MessageBox.Show("Please try again using a number");

        }
        }
        
    }
}    




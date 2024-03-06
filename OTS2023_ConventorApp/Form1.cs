using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class btnTest : Form
    {
        public btnTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//convert
        {
            if(btnMass.Checked)
            {
                string txt = txtLabel1.Text;
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

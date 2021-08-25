using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_IdleClicker
{
    public partial class Form1 : Form
    {
        int clicks = 0;
        int CP = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CLICK_Click(object sender, EventArgs e)
        {
            clicks += CP;
            label1.Text = "CLICKS\n"+clicks;
        }
    }
}

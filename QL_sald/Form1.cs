using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_sald
{
    public partial class Form1 : Form
    {
        private packages packageControl = new packages();
        public Form1()
        {
            InitializeComponent();
            slidePanel.Height = btnPackage.Height;
            panel3.Controls.Add(packageControl);
            packageControl.BringToFront();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnHome.Height;
            slidePanel.Top = btnHome.Top;
        }


        private void btnPackage_Click(object sender, EventArgs e)
        {
            slidePanel.Height = btnPackage.Height;
            slidePanel.Top = btnPackage.Top;
            packageControl.BringToFront();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

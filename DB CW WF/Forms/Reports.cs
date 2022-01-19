using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Report1Button_Click(object sender, EventArgs e)
        {
            new Report1().ShowDialog();
        }

        private void Report2Button_Click(object sender, EventArgs e)
        {
            new Report2().ShowDialog();
        }

        private void Report3Button_Click(object sender, EventArgs e)
        {
            new Report3().ShowDialog();
        }
    }
}

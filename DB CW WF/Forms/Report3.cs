using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class Report3 : Form
    {
        public Report3()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            clientsTextBox.Text = DbClient.Report3(fromDatePicker.Value, toDatePicker.Value).ToString();
        }
    }
}

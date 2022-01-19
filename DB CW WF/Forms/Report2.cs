using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var reuslt = DbClient.Report2(datePicker.Value);
            freeRoomsTextBox.Text = reuslt.Item1.ToString();
            notFreeRoomsTextBox.Text = reuslt.Item2.ToString();
        }
    }
}

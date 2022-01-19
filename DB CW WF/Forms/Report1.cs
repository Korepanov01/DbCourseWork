using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var rooms = DbClient.Report1(datePicker.Value);
            var listItems = rooms
                .Select(room => (object)$"{room.Number} ({DbClient.FindHotelById(room.HotelId).Name})")
                .ToArray();
            roomListBox.Items.Clear();
            roomListBox.Items.AddRange(listItems);
        }
    }
}

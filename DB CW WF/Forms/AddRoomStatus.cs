using System;
using System.Windows.Forms;
using DB_CW_WF.Entities;

namespace DB_CW_WF.Forms
{
    public partial class AddRoomStatus : Form
    {
        public int AddedRoomStatusId { get; private set; }
        
        public AddRoomStatus()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Введите название!", "Заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddedRoomStatusId = DbClient.InsertRoomStatus(new RoomStatus(nameTextBox.Text, isFreeCheckBox.Checked));
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

using System;
using System.Windows.Forms;
using DB_CW_WF.Entities;

namespace DB_CW_WF.Forms
{
    public partial class ChangeRoomStatus : Form
    {
        private readonly int _roomStatusId;
        public ChangeRoomStatus(int id)
        {
            _roomStatusId = id;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Введите название!", "Заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DbClient.UpdateRoomStatus(_roomStatusId, new RoomStatus(nameTextBox.Text, isFreeCheckBox.Checked));
            DialogResult = DialogResult.OK;
        }

        private void ChangeRoomStatus_Load(object sender, EventArgs e)
        {
            var room = DbClient.FindRoomStatusById(_roomStatusId);
            nameTextBox.Text = room.Name;
            isFreeCheckBox.Checked = room.IsFree;
        }
    }
}

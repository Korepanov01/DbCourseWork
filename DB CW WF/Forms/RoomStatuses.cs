using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class RoomStatuses : Form
    {
        private List<int> _roomStatusesIds;

        public RoomStatuses()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addRoomStatus = new AddRoomStatus();
            var result = addRoomStatus.ShowDialog();
            if (result != DialogResult.OK) return;
            var newPositionId = addRoomStatus.AddedRoomStatusId;
            _roomStatusesIds.Add(newPositionId);
            var newRoomStatus = DbClient.FindRoomStatusById(newPositionId);
            roomStatusesListBox.Items.Add(newRoomStatus.Name);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (roomStatusesListBox.SelectedIndex == -1)
            {
                return;
            }
            var changeRoomStatus = new ChangeRoomStatus(_roomStatusesIds[roomStatusesListBox.SelectedIndex]);
            var result = changeRoomStatus.ShowDialog();
            if (result == DialogResult.OK)
            {
                roomStatusesListBox.Items[roomStatusesListBox.SelectedIndex] =
                    DbClient.FindRoomStatusById(_roomStatusesIds[roomStatusesListBox.SelectedIndex]).Name;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (roomStatusesListBox.SelectedIndex == -1)
            {
                return;
            }
            
            try
            {
                DbClient.DeleteRoomStatus(_roomStatusesIds[roomStatusesListBox.SelectedIndex]);
                _roomStatusesIds.RemoveAt(roomStatusesListBox.SelectedIndex);
                roomStatusesListBox.Items.RemoveAt(roomStatusesListBox.SelectedIndex);
            }
            catch (SqlException)
            {
                MessageBox.Show("Статус используется!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RoomStatuses_Load(object sender, EventArgs e)
        {
            var roomStatuses = DbClient.FindAllRoomStatuses();
            _roomStatusesIds = roomStatuses.Select(roomStatus => roomStatus.Id).ToList();
            var items = roomStatuses.Select(roomStatus => (object)roomStatus.Name).ToArray();

            roomStatusesListBox.Items.AddRange(items);
        }
    }
}
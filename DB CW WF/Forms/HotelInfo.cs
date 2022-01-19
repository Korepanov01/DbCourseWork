using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DB_CW_WF.Entities;

namespace DB_CW_WF.Forms
{
    public partial class HotelInfo : Form
    {
        private readonly int _hotelId;
        private Hotel _hotel;

        private List<int> _roomIds;
        private List<int> _staffIds;

        public HotelInfo(int hotelId)
        {
            _hotelId = hotelId;
            _hotel = DbClient.FindHotelById(_hotelId);

            InitializeComponent();
        }

        private void HotelInfo_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = _hotel.Name;
            innTextBox.Text = _hotel.Inn;
            addressTextBox.Text = _hotel.Address;

            var staffs = DbClient.FindStaffsByHotelId(_hotelId);
            _staffIds = staffs.Select(staff => staff.Id).ToList();
            var listItems = staffs.Select(staff =>
                (object)$"{staff.FullName} ({DbClient.FindPositionById(staff.PositionId).Name})").ToArray();
            staffListBox.Items.Clear();
            staffListBox.Items.AddRange(listItems);

            var rooms = DbClient.FindRoomsByHotelId(_hotelId);
            _roomIds = rooms.Select(room => room.Id).ToList();
            listItems = rooms
                .Select(room => (object)$"{room.Number} ({DbClient.FindRoomStatusById(room.StatusId).Name})")
                .ToArray();
            roomListBox.Items.Clear();
            roomListBox.Items.AddRange(listItems);
        }

        private void ChangingSwitch()
        {
            nameTextBox.ReadOnly = !nameTextBox.ReadOnly;
            innTextBox.ReadOnly = !innTextBox.ReadOnly;
            addressTextBox.ReadOnly = !addressTextBox.ReadOnly;

            saveInfoChangesButton.Enabled = !saveInfoChangesButton.Enabled;
            cancelInfoChangingButton.Enabled = !cancelInfoChangingButton.Enabled;
            changeInfoButton.Enabled = !changeInfoButton.Enabled;
        }

        private void ChangeInfoButton_Click(object sender, EventArgs e)
        {
            ChangingSwitch();
        }

        private void SaveInfoChangesButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var inn = innTextBox.Text;
            var address = addressTextBox.Text;

            if (name == "" || inn == "" || address == "")
            {
                MessageBox.Show("Некоторые поля не заполнены", "Заполните все поля", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (inn.Length != 12 || !ulong.TryParse(inn, out _))
            {
                MessageBox.Show("ИНН должен состять из 12 цифр", "Неверный ИНН", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            ChangingSwitch();
            DbClient.UpdateHotel(_hotelId, new Hotel(name, inn, address));
            _hotel = DbClient.FindHotelById(_hotelId);
        }

        private void CancelInfoChangingButton_Click(object sender, EventArgs e)
        {
            ChangingSwitch();
            
            nameTextBox.Text = _hotel.Name;
            innTextBox.Text = _hotel.Inn;
            addressTextBox.Text = _hotel.Address;
        }

        private void StaffInfoButton_Click(object sender, EventArgs e)
        {
            if (staffListBox.SelectedIndex == -1)
                return;

            var selectedStaffId = _staffIds[staffListBox.SelectedIndex];
            var staffInfo = new StaffInfo(selectedStaffId);
            staffInfo.ShowDialog();
            var updatedStaff = DbClient.FindStaffById(selectedStaffId);
            staffListBox.Items[staffListBox.SelectedIndex] =
                $"{updatedStaff.FullName} ({DbClient.FindPositionById(updatedStaff.PositionId).Name})";
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            var addStaff = new AddStaff(_hotelId);
            var result = addStaff.ShowDialog();
            if (result != DialogResult.OK) return;
            var newStaffId = addStaff.AddedStaffId;
            _staffIds.Add(newStaffId);
            var newStaff = DbClient.FindStaffById(newStaffId);
            staffListBox.Items.Add($"{newStaff.FullName} ({DbClient.FindPositionById(newStaff.PositionId).Name})");
        }

        private void DeleteStaffButton_Click(object sender, EventArgs e)
        {
            if (staffListBox.SelectedIndex == -1)
            {
                return;
            }

            DbClient.DeleteStaff(_staffIds[staffListBox.SelectedIndex]);
            _staffIds.RemoveAt(staffListBox.SelectedIndex);
            staffListBox.Items.RemoveAt(staffListBox.SelectedIndex);
        }

        private void RoomInfoButton_Click(object sender, EventArgs e)
        {
            if (roomListBox.SelectedIndex == -1)
            {
                return;
            }

            var selectedRoomId = _roomIds[roomListBox.SelectedIndex];
            var roomInfo = new RoomInfo(selectedRoomId);
            roomInfo.ShowDialog();
            var updatedRoom = DbClient.FindRoomById(selectedRoomId);
            roomListBox.Items[roomListBox.SelectedIndex] =
                $"{updatedRoom.Number} ({DbClient.FindRoomStatusById(updatedRoom.StatusId).Name})";
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            var addRoom = new AddRoom(_hotelId);
            var result = addRoom.ShowDialog();
            if (result != DialogResult.OK) return;
            var newRoomId = addRoom.AddedRoomId;
            _roomIds.Add(newRoomId);
            var newRoom = DbClient.FindRoomById(newRoomId);
            roomListBox.Items.Add($"{newRoom.Number} ({DbClient.FindRoomStatusById(newRoom.StatusId).Name})");
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (roomListBox.SelectedIndex == -1)
            {
                return;
            }

            DbClient.DeleteRoom(_roomIds[roomListBox.SelectedIndex]);
            _roomIds.RemoveAt(roomListBox.SelectedIndex);
            roomListBox.Items.RemoveAt(roomListBox.SelectedIndex);
        }
    }
}
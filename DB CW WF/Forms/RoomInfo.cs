using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DB_CW_WF.Entities;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class RoomInfo : Form
    {
        private Client _client;
        private Room _room;
        private List<int> _statusesIds;

        public RoomInfo(int roomId)
        {
            _room = DbClient.FindRoomById(roomId);
            InitializeComponent();
        }
        
        private void ChangingSwitch()
        {
            numberTextBox.ReadOnly = !numberTextBox.ReadOnly;
            bedsCountTextBox.ReadOnly = !bedsCountTextBox.ReadOnly;
            descriptionTextBox.ReadOnly = !descriptionTextBox.ReadOnly;
            costPerDayTextBox.ReadOnly = !costPerDayTextBox.ReadOnly;
            statusesComboBox.Enabled = !statusesComboBox.Enabled;

            saveInfoChangesButton.Enabled = !saveInfoChangesButton.Enabled;
            cancelInfoChangingButton.Enabled = !cancelInfoChangingButton.Enabled;
            changeInfoButton.Enabled = !changeInfoButton.Enabled;
            clientInfoButton.Enabled = !clientInfoButton.Enabled;
            addClientButton.Enabled = !addClientButton.Enabled;
        }

        private void ChangeInfoButton_Click(object sender, System.EventArgs e)
        {
            ChangingSwitch();
            statusesComboBox.Text = "";
        }

        private void SaveInfoChangesButton_Click(object sender, System.EventArgs e)
        {
            if (numberTextBox.Text == "" || bedsCountTextBox.Text == "" || costPerDayTextBox.Text == "" || descriptionTextBox.Text == "" ||
                statusesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Некоторые поля не заполнены", "Заполните все поля", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(numberTextBox.Text, out var number) || !int.TryParse(bedsCountTextBox.Text, out var bedsCount) ||
                !decimal.TryParse(costPerDayTextBox.Text, out var costPerDay))
            {
                MessageBox.Show("Номер, число мест и цена должны быть числами!", "Введены некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bedsCount < 0 || costPerDay < 0)
            {
                MessageBox.Show("Число мест и цена не могут быть меньше нуля!", "Введены некорректные данные!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChangingSwitch();
            var statusId = _statusesIds[statusesComboBox.SelectedIndex];
            DbClient.UpdateRoom(_room.Id, new Room(number, _room.HotelId, descriptionTextBox.Text, bedsCount, costPerDay, statusId));
            _room = DbClient.FindRoomById(_room.Id);
        }

        private void CancelInfoChangingButton_Click(object sender, System.EventArgs e)
        {
            ChangingSwitch();
            
            numberTextBox.Text = _room.Number.ToString();
            bedsCountTextBox.Text = _room.BedsCount.ToString();
            costPerDayTextBox.Text = _room.CostPerDay.ToString(CultureInfo.CurrentCulture);
            descriptionTextBox.Text = _room.Description;
            statusesComboBox.Text = DbClient.FindRoomStatusById(_room.StatusId).Name;
        }

        private void AddClientButton_Click(object sender, System.EventArgs e)
        {
            var addClient = new AddClient(_room.Id);
            var result = addClient.ShowDialog();
            if (result == DialogResult.OK)
            {
                var newClientId = addClient.AddedClientId;
                _client = DbClient.FindClientById(newClientId);
                clientTextBox.Text = _client.FullName;
                clientInfoButton.Visible = true;
                addClientButton.Visible = false;
            }
        }

        private void ClientInfoButton_Click(object sender, System.EventArgs e)
        {
            var clientInfo = new ClientInfo(_client.Id);
            var result = clientInfo.ShowDialog();
            if (result == DialogResult.Abort)
            {
                _client = null;
                clientTextBox.Text = "Комната пуста";
                addClientButton.Visible = true;
                clientInfoButton.Visible = false;
            }
            else
            {
                _client = DbClient.FindClientById(_client.Id);
                clientTextBox.Text = _client.FullName;
            }
        }

        private void RoomInfo_Load(object sender, System.EventArgs e)
        {
            numberTextBox.Text = _room.Number.ToString();
            bedsCountTextBox.Text = _room.BedsCount.ToString();
            costPerDayTextBox.Text = _room.CostPerDay.ToString(CultureInfo.CurrentCulture);
            hotelTextBox.Text = DbClient.FindHotelById(_room.HotelId).Name;
            descriptionTextBox.Text = _room.Description;
            
            var statuses = DbClient.FindAllRoomStatuses();
            _statusesIds = statuses.Select(status => status.Id).ToList();
            statusesComboBox.Items.AddRange(statuses.Select(status => (object)status.Name).ToArray());

            _client = DbClient.FindClientByRoomId(_room.Id);
            if (_client != null)
            {
                clientTextBox.Text = _client.FullName;
                clientInfoButton.Visible = true;
            }
            else
            {
                clientTextBox.Text = "Комната пуста";
                addClientButton.Visible = true;
            }
        }
    }
}

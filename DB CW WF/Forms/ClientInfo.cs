using System.Globalization;
using System.Windows.Forms;
using DB_CW_WF.Entities;

namespace DB_CW_WF.Forms
{
    public partial class ClientInfo : Form
    {
        private Client _client;
        public ClientInfo(int clientId)
        {
            _client = DbClient.FindClientById(clientId);
            InitializeComponent();
        }
        
        private void ChangingSwitch()
        {
            nameTextBox.ReadOnly = !nameTextBox.ReadOnly;
            prepaidTextBox.ReadOnly = !prepaidTextBox.ReadOnly;
            descriptionTextBox.ReadOnly = !descriptionTextBox.ReadOnly;
            arrivalDatePicker.Enabled = !arrivalDatePicker.Enabled;
            departureDateDateTimePicker.Enabled = !departureDateDateTimePicker.Enabled;

            saveInfoChangesButton.Enabled = !saveInfoChangesButton.Enabled;
            cancelInfoChangingButton.Enabled = !cancelInfoChangingButton.Enabled;
            changeInfoButton.Enabled = !changeInfoButton.Enabled;
            deleteButton.Enabled = !deleteButton.Enabled;
        }

        private void ChangeInfoButton_Click(object sender, System.EventArgs e)
        {
            ChangingSwitch();
        }

        private void SaveInfoChangesButton_Click(object sender, System.EventArgs e)
        {
            if (nameTextBox.Text == "" || prepaidTextBox.Text == "" || descriptionTextBox.Text == "")
            {
                MessageBox.Show("Некоторые поля не заполнены", "Заполните все поля", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (arrivalDatePicker.Value > departureDateDateTimePicker.Value)
            {
                MessageBox.Show("Время заезда не может быть меньше времени отъезда!!", "Введены некорректные данные!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(prepaidTextBox.Text, out var prepaid))
            {
                MessageBox.Show("Предопалата должна быть числом!", "Введены некорректные данные!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (prepaid < 0)
            {
                MessageBox.Show("Предопалата не может быть меньше нуля!", "Введены некорректные данные!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DbClient.UpdateClient(_client.Id, (new Client(arrivalDatePicker.Value, departureDateDateTimePicker.Value,
                prepaid, descriptionTextBox.Text, _client.RoomId, nameTextBox.Text)));
            _client = DbClient.FindClientById(_client.Id);
            ChangingSwitch();
        }

        private void CancelInfoChangingButton_Click(object sender, System.EventArgs e)
        {
            ChangingSwitch();
            nameTextBox.Text = _client.FullName;
            prepaidTextBox.Text = _client.Prepaid.ToString(CultureInfo.CurrentCulture);
            arrivalDatePicker.Value = _client.ArrivalDate;
            departureDateDateTimePicker.Value = _client.DepartureDate;
            descriptionTextBox.Text = _client.Description;
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            DbClient.DeleteClient(_client.Id);
            DialogResult = DialogResult.Abort;
        }

        private void ClientInfo_Load(object sender, System.EventArgs e)
        {
            nameTextBox.Text = _client.FullName;
            prepaidTextBox.Text = _client.Prepaid.ToString(CultureInfo.CurrentCulture);
            arrivalDatePicker.Value = _client.ArrivalDate;
            departureDateDateTimePicker.Value = _client.DepartureDate;
            descriptionTextBox.Text = _client.Description;
            var room = DbClient.FindRoomById(_client.RoomId);
            hotelTextBox.Text = DbClient.FindHotelById(room.HotelId).Name;
            roomTextBox.Text = room.Number.ToString();
        }
    }
}
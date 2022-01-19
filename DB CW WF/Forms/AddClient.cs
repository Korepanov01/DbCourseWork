using System.Windows.Forms;
using DB_CW_WF.Entities;

namespace DB_CW_WF.Forms
{
    public partial class AddClient : Form
    {
        public int AddedClientId { get; private set; }
        private readonly int _roomId;

        public AddClient(int roomId)
        {
            InitializeComponent();
            _roomId = roomId;
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (nameTextBox.Text == "" || prepaidTextBox.Text == "" || descriptionTextBox.Text == "")
            {
                MessageBox.Show("Некоторые поля не заполнены", "Заполните все поля", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (arrivalDatePicker.Value > departureDateDateTimePicker.Value)
            {
                MessageBox.Show("Время заезда не может быть меньше времени отъезда!", "Введены некорректные данные!",
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

            AddedClientId = DbClient.InsertClient(new Client(arrivalDatePicker.Value, departureDateDateTimePicker.Value,
                prepaid, descriptionTextBox.Text, _roomId, nameTextBox.Text));
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

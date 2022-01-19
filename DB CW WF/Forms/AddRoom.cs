using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DB_CW_WF.Entities;

namespace DB_CW_WF.Forms
{
    public partial class AddRoom : Form
    {
        public int AddedRoomId { get; private set; }
        
        private List<int> _statusesIds;
        private readonly int _hotelId;

        public AddRoom(int hotelId)
        {
            _hotelId = hotelId;
            InitializeComponent();
        }
        
        private void AddButton_Click(object sender, System.EventArgs e)
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
            

            var statusId = _statusesIds[statusesComboBox.SelectedIndex];
            AddedRoomId = DbClient.InsertRoom(new Room(number, _hotelId, descriptionTextBox.Text, bedsCount, costPerDay, statusId));
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
        private void AddRoom_Load(object sender, System.EventArgs e)
        {
            var statuses = DbClient.FindAllRoomStatuses();
            _statusesIds = statuses.Select(status => status.Id).ToList();
            statusesComboBox.Items.AddRange(statuses.Select(status => (object)status.Name).ToArray());
        }
    }
}

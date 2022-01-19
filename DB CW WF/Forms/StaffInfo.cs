using DB_CW_WF.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class StaffInfo : Form
    {
        private readonly int _staffId;
        private Staff _staff;

        private List<int> _positionsId;

        private void ChangingSwitch()
        {
            nameTextBox.ReadOnly = !nameTextBox.ReadOnly;
            innTextBox.ReadOnly = !innTextBox.ReadOnly;
            positionComboBox.Enabled = !positionComboBox.Enabled;

            saveInfoChangesButton.Enabled = !saveInfoChangesButton.Enabled;
            cancelInfoChangingButton.Enabled = !cancelInfoChangingButton.Enabled;
            changeInfoButton.Enabled = !changeInfoButton.Enabled;
        }
        public StaffInfo(int staffId)
        {
            _staffId = staffId;
            _staff = DbClient.FindStaffById(staffId);

            InitializeComponent();
        }

        private void ChangeInfoButton_Click(object sender, EventArgs e)
        {
            ChangingSwitch();
            positionComboBox.Text = "";
        }

        private void SaveInfoChangesButton_Click(object sender, EventArgs e)
        {
            var fullName = nameTextBox.Text;
            var inn = innTextBox.Text;

            if (fullName == "" || inn == "" || positionComboBox.SelectedIndex == -1)
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
            DbClient.UpdateStaff(_staffId,
                new Staff(_staff.HotelId, inn, fullName, _positionsId[positionComboBox.SelectedIndex]));
            _staff = DbClient.FindStaffById(_staffId);
        }

        private void CancelInfoChangingButton_Click(object sender, EventArgs e)
        {
            ChangingSwitch();
            
            nameTextBox.Text = _staff.FullName;
            innTextBox.Text = _staff.Inn;
            positionComboBox.Text = DbClient.FindPositionById(_staff.PositionId).Name;
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = _staff.FullName;
            innTextBox.Text = _staff.Inn;
            hotelTextBox.Text = DbClient.FindHotelById(_staff.HotelId).Name;
            positionComboBox.Text = DbClient.FindPositionById(_staff.PositionId).Name;

            var positions = DbClient.FindAllPositions();
            _positionsId = positions.Select(position => position.Id).ToList();
            positionComboBox.Items.AddRange(positions.Select(position => (object)position.Name).ToArray());
        }
    }
}

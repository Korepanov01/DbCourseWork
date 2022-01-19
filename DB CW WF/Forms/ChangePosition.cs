using System;
using System.Windows.Forms;
using DB_CW_WF.Entities;

namespace DB_CW_WF.Forms
{
    public partial class ChangePosition : Form
    {
        private readonly int _positionId;

        public ChangePosition(int id)
        {
            _positionId = id;
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

            DbClient.UpdatePosition(_positionId, new Position(nameTextBox.Text));
            DialogResult = DialogResult.OK;
        }

        private void ChangePosition_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = DbClient.FindPositionById(_positionId).Name;
        }
    }
}

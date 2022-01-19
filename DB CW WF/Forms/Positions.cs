using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class Positions : Form
    {
        private List<int> _positionsIds;

        public Positions()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addPosition = new AddPosition();
            var result = addPosition.ShowDialog();
            if (result != DialogResult.OK) return;
            var newPositionId = addPosition.AddedPosition;
            _positionsIds.Add(newPositionId);
            var newPosition = DbClient.FindPositionById(newPositionId);
            positionsListBox.Items.Add(newPosition.Name);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (positionsListBox.SelectedIndex == -1)
            {
                return;
            }
            var changePosition = new ChangePosition(_positionsIds[positionsListBox.SelectedIndex]);
            var result = changePosition.ShowDialog();
            if (result == DialogResult.OK)
            {
                positionsListBox.Items[positionsListBox.SelectedIndex] =
                    DbClient.FindPositionById(_positionsIds[positionsListBox.SelectedIndex]).Name;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (positionsListBox.SelectedIndex == -1)
            {
                return;
            }

            try
            {
                DbClient.DeletePosition(_positionsIds[positionsListBox.SelectedIndex]);
                _positionsIds.RemoveAt(positionsListBox.SelectedIndex);
                positionsListBox.Items.RemoveAt(positionsListBox.SelectedIndex);
            }
            catch (SqlException)
            {
                MessageBox.Show("Должность используется!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Positions_Load(object sender, EventArgs e)
        {
            var positions = DbClient.FindAllPositions();
            _positionsIds = positions.Select(position => position.Id).ToList();
            var items = positions.Select(position => (object)position.Name).ToArray();

            positionsListBox.Items.AddRange(items);
        }
    }
}

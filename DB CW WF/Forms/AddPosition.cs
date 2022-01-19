using System;
using System.Windows.Forms;
using DB_CW_WF.Entities;

namespace DB_CW_WF.Forms
{
    public partial class AddPosition : Form
    {
        public int AddedPosition { get; private set; }

        public AddPosition()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Введите название!", "Заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddedPosition = DbClient.InsertPosition(new Position(nameTextBox.Text));
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

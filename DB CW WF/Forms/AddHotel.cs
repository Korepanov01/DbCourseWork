using DB_CW_WF.Entities;
using System;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class AddHotel : Form
    {
        public int AddedHotelId { get; private set; }

        public AddHotel()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
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
            
            AddedHotelId =
                DbClient.InsertHotel(new Hotel(nameTextBox.Text, innTextBox.Text, addressTextBox.Text));
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

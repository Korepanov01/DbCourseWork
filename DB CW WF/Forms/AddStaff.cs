using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DB_CW_WF.Entities;

namespace DB_CW_WF.Forms
{
    public partial class AddStaff : Form
    {
        public int AddedStaffId { get; private set; }
        
        private List<int> _positionsId;
        private readonly int _hotelId;

        public AddStaff(int hotelId)
        {
            _hotelId = hotelId;
            InitializeComponent();
        }

        private void Add_Click(object sender, System.EventArgs e)
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
            
            var positionId = _positionsId[positionComboBox.SelectedIndex];
            AddedStaffId = DbClient.InsertStaff(new Staff(_hotelId, inn, fullName, positionId));
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddStaff_Load(object sender, System.EventArgs e)
        {
            var positions = DbClient.FindAllPositions();
            _positionsId = positions.Select(position => position.Id).ToList();
            positionComboBox.Items.AddRange(positions.Select(position => (object)position.Name).ToArray());
        }
    }
}

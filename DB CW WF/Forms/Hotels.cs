using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DB_CW_WF.Forms
{
    public partial class Hotels : Form
    {
        private List<int> _hotelsIds;

        public Hotels()
        {
            InitializeComponent();
        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            FillHotelsListBox();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addHotel = new AddHotel();
            var result = addHotel.ShowDialog();
            if (result != DialogResult.OK) return;
            var newHotelId = addHotel.AddedHotelId;
            _hotelsIds.Add(newHotelId);
            var newHotel = DbClient.FindHotelById(newHotelId);
            hotelsListBox.Items.Add($"{newHotel.Name} ({newHotel.Address})");
        }

        private void HotelInfoButton_Click(object sender, EventArgs e)
        {
            if (hotelsListBox.SelectedIndex == -1)
            {
                return;
            }

            var selectedHotelId = _hotelsIds[hotelsListBox.SelectedIndex];
            new HotelInfo(selectedHotelId).ShowDialog();
            var updatedHotel = DbClient.FindHotelById(selectedHotelId);
            hotelsListBox.Items[hotelsListBox.SelectedIndex] = 
                $"{updatedHotel.Name}, {updatedHotel.Address} (свободных комнат: {DbClient.FreeRoomsCountInHotel(updatedHotel.Id)})";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DbTestFiller.RefillDb();
            FillHotelsListBox();
        }

        private void FillHotelsListBox()
        {
            var hotels = DbClient.FindAllHotels();
            _hotelsIds = hotels.Select(hotel => hotel.Id).ToList();
            var items = hotels.Select(hotel => 
                (object)$"{hotel.Name}, {hotel.Address} (свободных комнат: {DbClient.FreeRoomsCountInHotel(hotel.Id)})").ToArray();
            
            hotelsListBox.Items.Clear();
            hotelsListBox.Items.AddRange(items);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (hotelsListBox.SelectedIndex == -1)
            {
                return;
            }
            DbClient.DeleteHotel(_hotelsIds[hotelsListBox.SelectedIndex]);
            _hotelsIds.RemoveAt(hotelsListBox.SelectedIndex);
            hotelsListBox.Items.RemoveAt(hotelsListBox.SelectedIndex);
        }

        private void PositionsButton_Click(object sender, EventArgs e)
        {
            new Positions().ShowDialog();
        }

        private void RoomStatusesButton_Click(object sender, EventArgs e)
        {
            new RoomStatuses().ShowDialog();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            new Reports().ShowDialog();
        }
    }
}

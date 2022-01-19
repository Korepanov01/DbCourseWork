using DB_CW_WF.Entities;
using System;

namespace DB_CW_WF
{
    public static class DbTestFiller
    {
        public static void RefillDb()
        {
            DbClient.ClearDb();

            var hotels = new[]
            {
                new Hotel("HOTELZO",    "789456123963", "Ижевск, Школьная, 1"),
                new Hotel("HOTELFELLA", "456123789852", "Ижевск, Песочная, 3"),
                new Hotel("MOTEL.LY",   "123789456741", "Ижевск, Подлесная, 9"),
                new Hotel("HOTELIQ",    "951753456412", "Воткинск, Суворова, 5"),
                new Hotel("HOTELWHALE", "159753123789", "Глазов, Пролетарская, 10")
            };
            var hotelsIds = new int[hotels.Length];
            for (var i = 0; i < hotels.Length; i++)
            {
                hotelsIds[i] = DbClient.InsertHotel(hotels[i]);
            }


            var postions = new[]
            {
                new Position("Директор"),
                new Position("Менеджер"),
                new Position("Обсл. персонал"),
                new Position("Бухгалтер"),
                new Position("Кухонный работник")
            };
            var postionsIds = new int[postions.Length];
            for (var i = 0; i < postions.Length; i++)
            {
                postionsIds[i] = DbClient.InsertPosition(postions[i]);
            }

            var staffs = new[]
            {
                new Staff(hotelsIds[0], "858950519701", "Lavra Njord", postionsIds[0]),
                new Staff(hotelsIds[0], "759652759652", "Sinclair Inge", postionsIds[1]),
                new Staff(hotelsIds[0], "286711286711", "Adolfito Jody", postionsIds[2]),

                new Staff(hotelsIds[1], "786299786299", "Bjørg Mabel", postionsIds[0]),
                new Staff(hotelsIds[1], "770873770873", "Judikael Sarah", postionsIds[1]),
                new Staff(hotelsIds[1], "366177366177", "Kubilay Augustina", postionsIds[2]),
                new Staff(hotelsIds[1], "106313106313", "Mehveş Dolly", postionsIds[3]),
                new Staff(hotelsIds[1], "912072912072", "Xavier Roderick", postionsIds[4]),

                new Staff(hotelsIds[2], "447182447182", "Yianna Nadiyya", postionsIds[0]),
                new Staff(hotelsIds[2], "245270245270", "Eugénie Ghulam", postionsIds[1]),
                new Staff(hotelsIds[2], "461350461350", "Monique Tiw", postionsIds[2]),
                new Staff(hotelsIds[2], "736622736622", "Alisia Vragi", postionsIds[3]),

                new Staff(hotelsIds[3], "470110470110", "Doug Teodóra", postionsIds[0]),
                new Staff(hotelsIds[3], "643053643053", "Ugnė Luule", postionsIds[1]),
                new Staff(hotelsIds[3], "453162453162", "Frona Njáll", postionsIds[2]),
                new Staff(hotelsIds[3], "494087494087", "Mary Jo Élisabeth", postionsIds[3]),
                new Staff(hotelsIds[3], "751132751132", "Chipo Ally", postionsIds[4]),
                new Staff(hotelsIds[3], "978191978191", "Nikša Sachin", postionsIds[2]),

                new Staff(hotelsIds[4], "403254403254", "Adeodatus Dora", postionsIds[1]),
                new Staff(hotelsIds[4], "199014199014", "Dorit Vonda", postionsIds[2]),
                new Staff(hotelsIds[4], "745379745379", "Oaklyn Harish", postionsIds[3]),
                new Staff(hotelsIds[4], "110641110641", "Siddhartha Hanspeter", postionsIds[4]),
                new Staff(hotelsIds[4], "259998259998", "Engel Regina", postionsIds[1]),
                new Staff(hotelsIds[4], "833061833061", "Helge Cthulhu", postionsIds[2]),
                new Staff(hotelsIds[4], "280921280921", "Drahomíra Abhinav", postionsIds[3]),
            };
            var staffsIds = new int[staffs.Length];
            for (var i = 0; i < staffs.Length; i++)
            {
                staffsIds[i] = DbClient.InsertStaff(staffs[i]);
            }

            var roomStats = new[]
            {
                new RoomStatus("Ремонтируется", false),
                new RoomStatus("Доступна", true),
                new RoomStatus("Занята", false),
                new RoomStatus("Забронирована", false)
            };
            var roomStatsIds = new int[roomStats.Length];
            for (var i = 0; i < roomStats.Length; i++)
            {
                roomStatsIds[i] = DbClient.InsertRoomStatus(roomStats[i]);
            }

            var rooms = new[]
            {
                new Room(1, hotelsIds[0], "Что-то...", 1, 1923, roomStatsIds[0]),
                new Room(2, hotelsIds[0], "Что-то...", 2, 1472, roomStatsIds[1]),

                new Room(1, hotelsIds[1], "Что-то...", 1, 1259, roomStatsIds[0]),
                new Room(2, hotelsIds[1], "Что-то...", 2, 1734, roomStatsIds[1]),
                new Room(3, hotelsIds[1], "Что-то...", 3, 1580, roomStatsIds[2]),
                new Room(4, hotelsIds[1], "Что-то...", 4, 1634, roomStatsIds[3]),

                new Room(1, hotelsIds[2], "Что-то...", 1, 1906, roomStatsIds[0]),
                new Room(2, hotelsIds[2], "Что-то...", 2, 1671, roomStatsIds[1]),
                new Room(3, hotelsIds[2], "Что-то...", 3, 1195, roomStatsIds[3]),

                new Room(1, hotelsIds[3], "Что-то...", 1, 1347, roomStatsIds[0]),
                new Room(2, hotelsIds[3], "Что-то...", 2, 1124, roomStatsIds[1]),
                new Room(3, hotelsIds[3], "Что-то...", 3, 1308, roomStatsIds[2]),
                new Room(4, hotelsIds[3], "Что-то...", 4, 1949, roomStatsIds[3]),
                new Room(5, hotelsIds[3], "Что-то...", 5, 1436, roomStatsIds[0]),

                new Room(1, hotelsIds[4], "Что-то...", 1, 1739, roomStatsIds[1]),
                new Room(2, hotelsIds[4], "Что-то...", 2, 1658, roomStatsIds[2]),
                new Room(3, hotelsIds[4], "Что-то...", 3, 1634, roomStatsIds[3]),
                new Room(4, hotelsIds[4], "Что-то...", 4, 1580, roomStatsIds[0]),
                new Room(5, hotelsIds[4], "Что-то...", 5, 1898, roomStatsIds[1]),
                new Room(6, hotelsIds[4], "Что-то...", 6, 1316, roomStatsIds[2]),
            };
            var roomsIds = new int[rooms.Length];
            for (var i = 0; i < rooms.Length; i++)
            {
                roomsIds[i] = DbClient.InsertRoom(rooms[i]);
            }

            var clients = new[]
            {
                new Client(new DateTime(2021, 12, 11), new DateTime(2021, 12, 20), 720, "Что-то...", roomsIds[5], "Gwenaëlle Dipa"),
                new Client(new DateTime(2021, 12, 12), new DateTime(2021, 12, 21), 604, "Что-то...", roomsIds[8], "Sophocles Rigantona"),
                new Client(new DateTime(2021, 12, 13), new DateTime(2021, 12, 23), 226, "Что-то...", roomsIds[12], "Braith Tziporah"),
                new Client(new DateTime(2021, 12, 14), new DateTime(2021, 12, 21), 131, "Что-то...", roomsIds[16], "Citlali Hilda"),
                new Client(new DateTime(2021, 12, 2), new DateTime(2021, 12, 21), 786, "Что-то...", roomsIds[4], "Phrixus Saqui"),
                new Client(new DateTime(2021, 12, 3), new DateTime(2021, 12, 22), 467, "Что-то...", roomsIds[11], "Zenia Domitius"),
                new Client(new DateTime(2021, 12, 1), new DateTime(2021, 12, 25), 879, "Что-то...", roomsIds[15], "Norman Moshe"),
                new Client(new DateTime(2021, 12, 4), new DateTime(2021, 12, 24), 253, "Что-то...", roomsIds[19], "Esperanza Handan")
            };
            var clientsIds = new int[clients.Length];
            for (var i = 0; i < clients.Length; i++)
            {
                clientsIds[i] = DbClient.InsertClient(clients[i]);
            }
        }
    }
}

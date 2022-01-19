using System;
using DB_CW_WF.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DB_CW_WF
{
    public static class DbClient
    {
        private static readonly SqlConnection Connection =
            new SqlConnection("Data Source=DESKTOP-DSP926A;Initial Catalog=CourseWorkDB;Integrated Security=True");

        static DbClient()
        {
            Connection.Open();
        }

        public static void ClearDb()
        {
            var dataAdapter = new SqlDataAdapter();
            
            dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM [dbo].[Hotel];", Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
            
            dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM [dbo].[RoomStatus];", Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();

            dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM [dbo].[Position];", Connection);
            dataAdapter.DeleteCommand.ExecuteNonQuery();
        }

        private static int GetLastAddedObjectId()
        {
            int id;
            using var command = new SqlCommand("SELECT SCOPE_IDENTITY();", Connection);
            id = (int)(decimal)command.ExecuteScalar();
            return id;
        }

        //---------Client----------------

        public static int InsertClient(Client client)
        {
            var commandText =
                $"INSERT INTO [dbo].[Client] ([ArrivalDate], [DepartureDate], [Prepaid], [Description], [RoomId], [FullName]) VALUES ('{client.ArrivalDate}', '{client.DepartureDate}', '{client.Prepaid}', '{client.Description}', '{client.RoomId}', '{client.FullName}');";

            var dataAdapter = new SqlDataAdapter
            {
                InsertCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.InsertCommand.ExecuteNonQuery();

            return GetLastAddedObjectId();
        }
        
        public static Client FindClientById(int id)
        {
            var commandText = $"SELECT [ArrivalDate], [DepartureDate], [Prepaid], [Description], [RoomId], [FullName] FROM [dbo].[Client] WHERE Id = {id};";
            
            Client client;
            using var dataReader = new SqlCommand(commandText, Connection).ExecuteReader();
            if (!dataReader.Read()) return null;
            var arrivalDate = (DateTime)dataReader.GetValue(0);
            var departureDate = (DateTime)dataReader.GetValue(1);
            var prepaid= (decimal)dataReader.GetValue(2);
            var description = (string)dataReader.GetValue(3);
            var roomId = (int)dataReader.GetValue(4);
            var fullName = (string)dataReader.GetValue(5);
            client = new Client(id, arrivalDate, departureDate, prepaid, description, roomId, fullName);
            return client;
        }
        
        public static Client FindClientByRoomId(int roomId)
        {
            var commandText = $"SELECT [Id] FROM [dbo].[Client] WHERE [RoomId] = {roomId};";

            int id;
            using (var dataReader = new SqlCommand(commandText, Connection).ExecuteReader())
            {
                if (!dataReader.Read()) return null;
                id = (int)dataReader.GetValue(0);
            }
            
            return FindClientById(id);
        }

        public static void UpdateClient(int clientId, Client client)
        {
            var commandText =
                $"UPDATE [dbo].[Client] SET ArrivalDate = '{client.ArrivalDate}', DepartureDate = '{client.DepartureDate}', Prepaid = '{client.Prepaid}', Description = '{client.Description}' , RoomId = '{client.RoomId}' , FullName = '{client.FullName}' WHERE Id = {clientId}";

            var dataAdapter = new SqlDataAdapter
            {
                UpdateCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.UpdateCommand.ExecuteNonQuery();
        }
        
        public static void DeleteClient(int id)
        {
            var dataAdapter = new SqlDataAdapter
            {
                DeleteCommand = new SqlCommand($"DELETE FROM [dbo].[Client] WHERE Id = {id};", Connection)
            };
            dataAdapter.DeleteCommand.ExecuteNonQuery();
        }

        //---------Hotel----------------

        public static int InsertHotel(Hotel hotel)
        {
            var commandText =
                $"INSERT INTO [dbo].[Hotel] ([Name] ,[Inn], [Address]) VALUES ('{hotel.Name}', '{hotel.Inn}', '{hotel.Address}');";

            var dataAdapter = new SqlDataAdapter
            {
                InsertCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.InsertCommand.ExecuteNonQuery();

            return GetLastAddedObjectId();
        }

        public static List<Hotel> FindAllHotels()
        {
            var commandText = "SELECT [Id], [Name], [Inn], [Address] FROM [dbo].[Hotel];";
            var command = new SqlCommand(commandText, Connection);

            var hotels = new List<Hotel>();
            using var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var id = (int)dataReader.GetValue(0);
                var name = (string)dataReader.GetValue(1);
                var inn = (string)dataReader.GetValue(2);
                var address = (string)dataReader.GetValue(3);
                hotels.Add(new Hotel(id, name, inn, address));
            }

            return hotels;
        }

        public static Hotel FindHotelById(int hotelId)
        {
            var commandText = $"SELECT [Id], [Name], [Inn], [Address] FROM [dbo].[Hotel] WHERE [Id] = {hotelId};";
            var command = new SqlCommand(commandText, Connection);

            int id;
            string name, inn, address;
            using (var dataReader = command.ExecuteReader())
            {
                if (!dataReader.Read()) return null;
                id = (int)dataReader.GetValue(0);
                name = (string)dataReader.GetValue(1);
                inn = (string)dataReader.GetValue(2);
                address = (string)dataReader.GetValue(3);
            }
            return new Hotel(id, name, inn, address);
        }

        public static void UpdateHotel(int hotelId, Hotel hotel)
        {
            var commandText = $"UPDATE [dbo].[Hotel] SET Name = '{hotel.Name}', Inn = '{hotel.Inn}', Address = '{hotel.Address}'  WHERE Id = {hotelId}";

            var dataAdapter = new SqlDataAdapter
            {
                UpdateCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.UpdateCommand.ExecuteNonQuery();
        }
        
        public static void DeleteHotel(int id)
        {
            var dataAdapter = new SqlDataAdapter
            {
                DeleteCommand = new SqlCommand($"DELETE FROM [dbo].[Hotel] WHERE Id = {id};", Connection)
            };
            dataAdapter.DeleteCommand.ExecuteNonQuery();
        }

        //---------Position----------------

        public static int InsertPosition(Position postion)
        {
            var commandText =
                $"INSERT INTO [dbo].[Position] ([Name]) VALUES ('{postion.Name}');";

            var dataAdapter = new SqlDataAdapter
            {
                InsertCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.InsertCommand.ExecuteNonQuery();

            return GetLastAddedObjectId();
        }

        public static Position FindPositionById(int id)
        {
            var commandText = $"SELECT [Name] FROM [dbo].[Position] WHERE [Id] = {id};";
            var command = new SqlCommand(commandText, Connection);

            string name;
            using (var dataReader = command.ExecuteReader())
            {
                if (!dataReader.Read()) return null;
                name = (string)dataReader.GetValue(0);
            }
            return new Position(id, name);
        }

        public static List<Position> FindAllPositions()
        {
            var commandText = "SELECT [Id], [Name] FROM [dbo].[Position];";
            var command = new SqlCommand(commandText, Connection);

            var positions = new List<Position>();
            using var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var id = (int)dataReader.GetValue(0);
                var name = (string)dataReader.GetValue(1);
                positions.Add(new Position(id, name));
            }

            return positions;
        }
        
        public static void UpdatePosition(int positionId, Position position)
        {
            var commandText = $"UPDATE [dbo].[Position] SET Name = '{position.Name}' WHERE Id = {positionId}";

            var dataAdapter = new SqlDataAdapter
            {
                UpdateCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.UpdateCommand.ExecuteNonQuery();
        }
        
        public static void DeletePosition(int id)
        {
            var dataAdapter = new SqlDataAdapter
            {
                DeleteCommand = new SqlCommand($"DELETE FROM [dbo].[Position] WHERE Id = {id};", Connection)
            };
            dataAdapter.DeleteCommand.ExecuteNonQuery();
        }

        //---------Room----------------

        public static int InsertRoom(Room room)
        {
            var commandText =
                $"INSERT INTO [dbo].[Room] ([HotelId], [Description], [BedsCount], [CostPerDay], [StatusId], [Number]) VALUES ('{room.HotelId}', '{room.Description}', '{room.BedsCount}', '{room.CostPerDay}', '{room.StatusId}', '{room.Number}');";

            var dataAdapter = new SqlDataAdapter
            {
                InsertCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.InsertCommand.ExecuteNonQuery();

            return GetLastAddedObjectId();
        }

        public static List<Room> FindRoomsByHotelId(int hotelId)
        {
            var commandText = $"SELECT [Id], [Description], [BedsCount], [CostPerDay], [StatusId], [Number] FROM [dbo].[Room] WHERE HotelId = {hotelId};";
            var command = new SqlCommand(commandText, Connection);

            var rooms = new List<Room>();
            using var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var id = (int)dataReader.GetValue(0);
                var description = (string)dataReader.GetValue(1);
                var bedsCount = (int)dataReader.GetValue(2);
                var costPerDay = (decimal)dataReader.GetValue(3);
                var statusId = (int)dataReader.GetValue(4);
                var number = (int)dataReader.GetValue(5);
                rooms.Add(new Room(id, number, hotelId, description, bedsCount, costPerDay, statusId));
            }

            return rooms;
        }

        public static Room FindRoomById(int id)
        {
            var commandText = $"SELECT [HotelId], [Description], [BedsCount], [CostPerDay], [StatusId], [Number] FROM [dbo].[Room] WHERE Id = {id};";
            var command = new SqlCommand(commandText, Connection);

            Room room;
            using var dataReader = command.ExecuteReader();
            if (!dataReader.Read())
            {
                return null;
            }

            var hotelId = (int)dataReader.GetValue(0);
            var description = (string)dataReader.GetValue(1);
            var bedsCount = (int)dataReader.GetValue(2);
            var costPerDay = (decimal)dataReader.GetValue(3);
            var statusId = (int)dataReader.GetValue(4);
            var number = (int)dataReader.GetValue(5);
            room = new Room(id, number, hotelId, description, bedsCount, costPerDay, statusId);
            return room;
        }
        
        public static void UpdateRoom(int roomId, Room room)
        {
            var commandText = $"UPDATE [dbo].[Room] SET HotelId = '{room.HotelId}', Description = '{room.Description}', BedsCount = '{room.BedsCount}', CostPerDay = '{room.CostPerDay}', StatusId = '{room.StatusId}', Number = '{room.Number}' WHERE Id = {roomId}";

            var dataAdapter = new SqlDataAdapter
            {
                UpdateCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.UpdateCommand.ExecuteNonQuery();
        }
        
        public static void DeleteRoom(int id)
        {
            var dataAdapter = new SqlDataAdapter
            {
                DeleteCommand = new SqlCommand($"DELETE FROM [dbo].[Room] WHERE Id = {id};", Connection)
            };
            dataAdapter.DeleteCommand.ExecuteNonQuery();
        }
        
        //---------RoomStatus----------------

        public static int InsertRoomStatus(RoomStatus roomStatus)
        {
            var commandText =
                $"INSERT INTO [dbo].[RoomStatus] ([Name], [IsFree]) VALUES ('{roomStatus.Name}', '{roomStatus.IsFree}');";

            var dataAdapter = new SqlDataAdapter
            {
                InsertCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.InsertCommand.ExecuteNonQuery();

            return GetLastAddedObjectId();
        }

        public static RoomStatus FindRoomStatusById(int id)
        {
            var commandText = $"SELECT [Name], [IsFree] FROM [dbo].[RoomStatus] WHERE [Id] = {id};";
            var command = new SqlCommand(commandText, Connection);

            RoomStatus roomStatus;
            using (var dataReader = command.ExecuteReader())
            {
                if (!dataReader.Read()) return null;
                var name = (string)dataReader.GetValue(0);
                var isFree = (bool)dataReader.GetValue(1);
                roomStatus = new RoomStatus(name, isFree);
            }
            return roomStatus;
        }
        
        public static List<RoomStatus> FindAllRoomStatuses()
        {
            var commandText = "SELECT [Id], [Name], [IsFree] FROM [dbo].[RoomStatus];";
            var command = new SqlCommand(commandText, Connection);

            var roomStatuses = new List<RoomStatus>();
            using var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var id = (int)dataReader.GetValue(0);
                var name = (string)dataReader.GetValue(1);
                var isFree = (bool)dataReader.GetValue(2);
                roomStatuses.Add(new RoomStatus(id, name, isFree));
            }

            return roomStatuses;
        }
        
        public static void UpdateRoomStatus(int roomStatusId, RoomStatus roomStatus)
        {
            var commandText = $"UPDATE [dbo].[RoomStatus] SET Name = '{roomStatus.Name}', [IsFree] = '{roomStatus.IsFree}' WHERE Id = {roomStatusId}";

            var dataAdapter = new SqlDataAdapter
            {
                UpdateCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.UpdateCommand.ExecuteNonQuery();
        }
        
        public static void DeleteRoomStatus(int id)
        {
            var dataAdapter = new SqlDataAdapter
            {
                DeleteCommand = new SqlCommand($"DELETE FROM [dbo].[RoomStatus] WHERE Id = {id};", Connection)
            };
            dataAdapter.DeleteCommand.ExecuteNonQuery();
        }

        //---------Staff----------------

        public static int InsertStaff(Staff staff)
        {
            var commandText =
                $"INSERT INTO [dbo].[Staff] ([HotelId], [Inn], [FullName], [PositionId]) VALUES ('{staff.HotelId}', '{staff.Inn}', '{staff.FullName}', '{staff.PositionId}');";

            var dataAdapter = new SqlDataAdapter
            {
                InsertCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.InsertCommand.ExecuteNonQuery();

            return GetLastAddedObjectId();
        }

        public static List<Staff> FindStaffsByHotelId(int hotelId)
        {
            var commandText = $"SELECT [Id], [Inn], [FullName], [PositionId] FROM [dbo].[Staff] WHERE HotelId = {hotelId};";
            var command = new SqlCommand(commandText, Connection);

            var staffs = new List<Staff>();
            using var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var id = (int)dataReader.GetValue(0);
                var inn = (string)dataReader.GetValue(1);
                var fullName = (string)dataReader.GetValue(2);
                var positionId = (int)dataReader.GetValue(3);
                staffs.Add(new Staff(id, hotelId, inn, fullName, positionId));
            }

            return staffs;
        }

        public static Staff FindStaffById(int id)
        {
            var commandText = $"SELECT [HotelId], [Inn], [FullName], [PositionId] FROM [dbo].[Staff] WHERE Id = {id};";
            var command = new SqlCommand(commandText, Connection);

            Staff staff;
            using var dataReader = command.ExecuteReader();
            if (!dataReader.Read())
            {
                return null;
            }

            var hotelId = (int)dataReader.GetValue(0);
            var inn = (string)dataReader.GetValue(1);
            var fullName = (string)dataReader.GetValue(2);
            var positionId = (int)dataReader.GetValue(3);
            staff = new Staff(id, hotelId, inn, fullName, positionId);
            return staff;
        }

        public static void UpdateStaff(int staffId, Staff staff)
        {
            var commandText = $"UPDATE [dbo].[Staff] SET HotelId = '{staff.HotelId}', Inn = '{staff.Inn}', FullName = '{staff.FullName}', PositionId = '{staff.PositionId}' WHERE Id = {staffId}";

            var dataAdapter = new SqlDataAdapter
            {
                UpdateCommand = new SqlCommand(commandText, Connection)
            };
            dataAdapter.UpdateCommand.ExecuteNonQuery();
        }
        
        public static void DeleteStaff(int id)
        {
            var dataAdapter = new SqlDataAdapter
            {
                DeleteCommand = new SqlCommand($"DELETE FROM [dbo].[Staff] WHERE Id = {id};", Connection)
            };
            dataAdapter.DeleteCommand.ExecuteNonQuery();
        }

        //---------------Views----------

        public static int FreeRoomsCountInHotel(int hotelId)
        {
            var commandText = $"SELECT [FreeRoomsCount] FROM [dbo].[FreeRoomsInHotels] WHERE [HotelId] = {hotelId};";
            var command = new SqlCommand(commandText, Connection);

            using var dataReader = command.ExecuteReader();
            if (!dataReader.Read())
            {
                return -1;
            }

            var freeRoomsCount = (int)dataReader.GetValue(0);
            return freeRoomsCount;
        }

        //-----------------Reports-----------

        public static List<Room> Report1(DateTime dateTime)
        {
            var commandText = "SELECT [R].[Id], [R].[Description], [R].[BedsCount], [R].[CostPerDay], [R].[StatusId], [R].[Number], [R].[HotelId] " +
                "FROM [dbo].[Room] AS R " +
                "JOIN RoomStatus AS RS " +
                "ON R.StatusId = RS.Id " +
                "WHERE RS.IsFree = 1 " +
                "UNION " +
                "SELECT [R].[Id], [R].[Description], [R].[BedsCount], [R].[CostPerDay], [R].[StatusId], [R].[Number], [R].[HotelId] " +
                "FROM [dbo].[Room] AS R " +
                "JOIN RoomStatus AS RS " +
                "ON R.StatusId = RS.Id " +
                "LEFT JOIN Client AS C " +
                "ON C.RoomId = R.Id " +
                "WHERE RS.IsFree = 0 AND " +
                $"(C.ArrivalDate > '{dateTime}' OR C.DepartureDate < '{dateTime}')";
            var command = new SqlCommand(commandText, Connection);

            var rooms = new List<Room>();
            using var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var id = (int)dataReader.GetValue(0);
                var description = (string)dataReader.GetValue(1);
                var bedsCount = (int)dataReader.GetValue(2);
                var costPerDay = (decimal)dataReader.GetValue(3);
                var statusId = (int)dataReader.GetValue(4);
                var number = (int)dataReader.GetValue(5);
                var hotelId = (int)dataReader.GetValue(6);
                rooms.Add(new Room(id, number, hotelId, description, bedsCount, costPerDay, statusId));
            }

            return rooms;
        }

        public static (int, int) Report2(DateTime dateTime)
        {
            var commandText = "SELECT COUNT(*) " +
                "FROM Room " +
                "WHERE Id in " +
                "( " +
                "SELECT [R].[Id] " +
                "FROM [dbo].[Room] AS R " +
                "JOIN RoomStatus AS RS " +
                "ON R.StatusId = RS.Id " +
                "WHERE RS.IsFree = 1 " +
                "UNION " +
                "SELECT [R].[Id] " +
                "FROM [dbo].[Room] AS R " +
                "JOIN RoomStatus AS RS " +
                "ON R.StatusId = RS.Id " +
                "LEFT JOIN Client AS C " +
                "ON C.RoomId = R.Id " +
                "WHERE RS.IsFree = 0 AND " +
                $"(C.ArrivalDate > '{dateTime}' OR C.DepartureDate < '{dateTime}') " +
                ")";
            var dataReader = new SqlCommand(commandText, Connection).ExecuteReader();

            int freeRoomsCount;
            if (!dataReader.Read())
            {
                return (-1, -1);
            }
            freeRoomsCount = (int)dataReader.GetValue(0);
            dataReader.Close();

            commandText = "SELECT COUNT(*) " +
                "FROM Room";
            dataReader = new SqlCommand(commandText, Connection).ExecuteReader();
            int notFreeRoomsCount;
            if (!dataReader.Read())
            {
                return (-1, -1);
            }
            notFreeRoomsCount = (int)dataReader.GetValue(0) - freeRoomsCount;
            dataReader.Close();

            return (freeRoomsCount, notFreeRoomsCount);
        }

        public static int Report3(DateTime fromDate, DateTime toDate)
        {
            var commandText = "SELECT COUNT(*) " +
                "FROM [dbo].Client " +
                $"WHERE ArrivalDate > '{fromDate}' AND ArrivalDate < '{toDate}' OR " +
                $"DepartureDate > '{fromDate}' AND DepartureDate < '{toDate}'";
            using var dataReader = new SqlCommand(commandText, Connection).ExecuteReader();

            if (!dataReader.Read())
            {
                return -1;
            }
            return (int)dataReader.GetValue(0);
        }
    }
}
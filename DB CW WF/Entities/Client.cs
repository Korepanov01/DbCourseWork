using System;

namespace DB_CW_WF.Entities
{
    public class Client
    {
        public int Id { get; }
        public DateTime ArrivalDate { get; }
        public DateTime DepartureDate { get; }
        public decimal Prepaid { get; }
        public string Description { get; }
        public int RoomId { get; }
        public string FullName { get; }

        public Client(DateTime arrivalDate, DateTime departureDate, decimal prepaid, string description, int roomId, string fullName)
        {
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            Prepaid = prepaid;
            Description = description;
            RoomId = roomId;
            FullName = fullName;
        }

        public Client(int id, DateTime arrivalDate, DateTime departureDate, decimal prepaid, string description,
            int roomId, string fullName) : this(arrivalDate, departureDate, prepaid, description, roomId, fullName)
        {
            Id = id;    
        }
    }
}

namespace DB_CW_WF.Entities
{
    public class Room
    {
        public int Id { get; }
        public int Number { get; }
        public int HotelId { get; }
        public string Description { get; }
        public int BedsCount { get; }
        public decimal CostPerDay { get; }
        public int StatusId { get; }

        public Room(int number, int hotelId, string description, int bedsCount, decimal costPerDay, int statusId)
        {
            Number = number;
            HotelId = hotelId;
            Description = description;
            BedsCount = bedsCount;
            CostPerDay = costPerDay;
            StatusId = statusId;
        }

        public Room(int id, int number, int hotelId, string description, int bedsCount, decimal costPerDay, int statusId) : this(
            number, hotelId, description, bedsCount, costPerDay, statusId)
        {
            Id = id;
        }
    }
}

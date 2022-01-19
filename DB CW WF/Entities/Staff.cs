namespace DB_CW_WF.Entities
{
    public class Staff
    {
        public int Id { get; }
        public int HotelId { get; }
        public string Inn { get; }
        public string FullName { get; }
        public int PositionId { get; }

        public Staff(int hotelId, string inn, string fullName, int positionId)
        {
            HotelId = hotelId;
            Inn = inn;
            FullName = fullName;
            PositionId = positionId;
        }

        public Staff(int id, int hotelId, string inn, string fullName, int positionId) : this(hotelId, inn, fullName,
            positionId)
        {
            Id = id;
        }
    }
}

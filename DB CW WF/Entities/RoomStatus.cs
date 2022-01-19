namespace DB_CW_WF.Entities
{
    public class RoomStatus
    {
        public int Id { get; }
        public string Name { get; }
        public bool IsFree { get; }

        public RoomStatus(string name, bool isFree)
        {
            Name = name;
            IsFree = isFree;
        }

        public RoomStatus(int id, string name, bool isFree) : this(name, isFree)
        {
            Id = id;
        }
    }
}

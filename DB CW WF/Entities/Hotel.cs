namespace DB_CW_WF.Entities
{
    public class Hotel
    {
        public int Id { get; }
        public string Name { get; }
        public string Inn { get; }
        public string Address { get; }

        public Hotel(string name, string inn, string address)
        {
            Name = name;
            Inn = inn;
            Address = address;
        }

        public Hotel(int id, string name, string inn, string address) : this(name, inn, address)
        {
            Id = id;
        }
    }
}

namespace DB_CW_WF.Entities
{
    public class Position
    {
        public int Id { get; }
        public string Name { get; }

        public Position(string name)
        {
            Name = name;
        }

        public Position(int id, string name) : this(name)
        {
            Id = id;
        }
    }
}

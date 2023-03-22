namespace Api.Models
{
    public class Faction
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Faction(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }
    }
}

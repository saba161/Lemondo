namespace Lemondo.Core.Models.Statements
{
    public class Statement
    {
        public Statement(int id, string name, string description, string photo)
        {
            Id = id;
            Name = name;
            Description = description;
            Photo = photo;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}

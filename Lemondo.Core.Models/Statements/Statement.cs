namespace Lemondo.Core.Models.Statements
{
    public class Statement
    {
        public Statement(string name, string description, byte photo)
        {
            Name = name;
            Description = description;
            Photo = photo;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Photo { get; set; }
    }
}

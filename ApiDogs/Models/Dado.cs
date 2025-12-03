namespace ApiDogs.Models
{
    public class Dado
    {
        public Guid Id { get; set; } 
        public string DogType { get; set; }
        public Attribute Attribute { get; set; }
        public Relationship Relationship { get; set; }
    }
}

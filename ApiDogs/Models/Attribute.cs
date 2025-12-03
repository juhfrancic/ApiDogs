namespace ApiDogs.Models
{
    public class Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Length Life { get; set; }
        public Length FemaleWeight { get; set; }
        public Length MaleWeight { get; set; }
        public bool Hypoallergenic { get; set; }
    }
}

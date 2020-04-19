namespace Models.Models
{
    public class Owner : BaseModel
    {
        public string Name { get; set; }
        public string Profil { get; set; }
        public string Picture { get; set; }
        public Address Address { get; set; }
    }
}

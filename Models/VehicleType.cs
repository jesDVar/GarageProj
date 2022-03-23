namespace GarageProj.Models
{
    public class VehicleType
    {
        public int Id { get; set; }
        public int SlotSize { get; set; }
        public string Name { get; set; }

        //Nav prop

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}

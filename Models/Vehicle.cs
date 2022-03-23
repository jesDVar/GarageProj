
namespace GarageProj.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? RegNr { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Wheels { get; set; }

        //Nav prop

        public Member Member { get; set; }
        public ICollection<ParkingSlot> ParkingSlots { get; set; } = new List<ParkingSlot>();
        public VehicleType VehicleType { get; set; }

        public int MemberId { get; set; }
        public int VehicleTypeId { get; set; }
    }
}

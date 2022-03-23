namespace GarageProj.Models
{
    public class ParkingSlot
    {
        public int Id { get; set; }
        public int SlotNr { get; set; }

        //Nav prop
        public Vehicle Vehicle { get; set; }
    }
}

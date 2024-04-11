namespace InventoryXpert.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime ArrivalDate { get; set;}
        public int Shipped { get; set; }
        public DateTime PlacedDate { get; set;}
        public int Supplier { get; set;}
        public Order() { }
    }
}

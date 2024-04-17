namespace InventoryXpert.Models
{
    public class OrderRecord
    {
        public int OrderRecordID { get; set; }
        public int OrderID { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public OrderRecord() { }
    }
}

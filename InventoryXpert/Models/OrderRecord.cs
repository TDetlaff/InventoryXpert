using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryXpert.Models
{
    public class OrderRecord
    {
        [Key]
        public int OrderRecordId { get; set; }

        // Foreign key property for the related Order
        public int? OrderId { get; set; }

        // Navigation property to represent the related Order
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        // Foreign key property for the related Item
        public int? ItemId { get; set; }

        // Navigation property to represent the related Item
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        public int Quantity { get; set; }
        public OrderRecord() { }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryXpert.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public bool Shipped { get; set; }
        public DateTime? ArrivalDate { get; set;}
        public DateTime? PlacedDate { get; set;}

        // Foreign key property for the related Supplier
        public int SupplierId { get; set; }

        public Order() { }

        // Navigation property to represent the related Supplier
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        // Navigation property to represent the collection of related OrderRecords
        public ICollection<OrderRecord>  OrderRecords { get; set; }
    }
}

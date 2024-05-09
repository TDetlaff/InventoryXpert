using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryXpert.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }

        // Foreign key property for the related Category
        public int? CategoryId { get; set; }

        public int? StockedQuantity { get; set; }
        public int? AvailableQuantity { get; set; }
        public int? QuantityOnOrder { get; set; }
        public float? Price { get; set; }
        public string? Location { get; set; }
        public string? TagA { get; set; }
        public string? TagB { get; set; }
        public string? TagC { get; set; }
        public string? TagD { get; set; }
        public string? TagE { get; set; }
        public Item() { }

        // Navigation property to represent the related Category
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}

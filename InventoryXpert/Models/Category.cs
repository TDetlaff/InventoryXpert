using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryXpert.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Group { get; set; }

       // Foreign key property for the related Supplier
        public int? SupplierId { get; set; }

        public Category() { }

        // Navigation property to represent the related Supplier
        [ForeignKey("SupplierId")]
        public Supplier? Supplier { get; set; }

        // Navigation property to represent the collection of related Items
        public ICollection<Item>? Items { get; set; }
    }
}

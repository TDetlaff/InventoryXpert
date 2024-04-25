using System.ComponentModel.DataAnnotations;

namespace InventoryXpert.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string? SupplierName { get; set;}
        public string? Address { get; set;}
        public string? City { get; set;}
        public string? Region { get; set;}
        public int? PostalCode { get; set;}
        public string? Country { get; set;}
        public string? Phone { get; set;}
        public string? Fax { get; set;}
        public string? Email { get; set;}

        /*// Navigation property to represent the collection of related Orders
        public ICollection<Order> Orders { get; set; }*/

        /*// Navigation property to represent the collection of related Categories
        public ICollection<Category> Categories { get; set; }*/
    }
}

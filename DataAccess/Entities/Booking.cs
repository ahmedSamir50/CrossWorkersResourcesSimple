using DataAccess.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    [Table("Bookings")]
    public class Booking : IHasKey<int>, IAuditableDate, IActivEntity
    {
        [Key]
        public int ID { get ; set ; }
        public int ResourceId { get; set; }
        public int BookedQuantity { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModifiedAt { get ; set ; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        [ForeignKey("ResourceId")]
        public virtual Resource Resource { get; set; }
    }
}

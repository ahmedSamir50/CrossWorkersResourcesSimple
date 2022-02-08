using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    [Table("Resources")]
    [Index("Name")]
    public class Resource : IHasKey<int>, IActivEntity, IAuditableDate
    {
        [Key]
        public int ID { get ; set ; }
        public string Name { get; set; }
        public int Quantity{ get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModifiedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}

using System;
namespace DataAccess.Interfaces
{
    public interface IAuditableDate
    {
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }

}

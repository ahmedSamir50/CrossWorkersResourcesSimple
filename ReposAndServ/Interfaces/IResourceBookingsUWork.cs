using ReposAndServ.Utils.Models;
using System;
using System.Threading.Tasks;

namespace ReposAndServ.Interfaces
{
    public interface IResourceBookingsUWork
    {
        IBookingRepo BookingRepo { get; }
        IResourceRepo ResourcesRepo { get; }

        Task<ResourceAvailability> ValidateResourceAvailability(DateTime from, DateTime to, int ofResource);
        Task<int> SaveChanges();
    }
}

using DataAccess.Entities;
using DataAccess.WorkersDbContext;
using ReposAndServ.Interfaces;
using ReposAndServ.Utils.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ReposAndServ.UWorks
{
    public class ResourceBookingsUWork : IResourceBookingsUWork
    {
        #region Props
        public IBookingRepo BookingRepo { get => _bookingRepo; }
        public IResourceRepo ResourcesRepo { get => _resourceRepo; }
        private readonly ResourcesDbContext _context;
        readonly IBookingRepo _bookingRepo;
        readonly IResourceRepo _resourceRepo;
        #endregion Props
        public ResourceBookingsUWork(IBookingRepo booking, IResourceRepo resources , ResourcesDbContext context)
        {
            _bookingRepo = booking;
            _resourceRepo = resources;
            _context = context;
        }


        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        #region Validate
        /// <summary>
        /// Validating a resource validity in certain time period 
        /// </summary>
        /// <param name="from">starting from date </param>
        /// <param name="to">until date </param>
        /// <param name="ofResource">needed resource to validate </param>
        /// <returns></returns>
        public async Task<ResourceAvailability> ValidateResourceAvailability(DateTime from, DateTime to, int ofResource)
        {

            var res = await FindResourceAndBookings(ResourcesRepo, ofResource);
            var valied = CalculateAvilibitlity(from, to , res);
            return valied;
        }
       
        /// <summary>
        /// validating resource availability
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="res"></param>
        /// <returns></returns>
        private static ResourceAvailability CalculateAvilibitlity(DateTime from, DateTime to, Resource res)
            {
                var valied = new ResourceAvailability();
                if (res != null)
                {
                    var bookings = res.Bookings.Where(d => 
                                                                      // booked within  the same period 
                                                                      (d.DateFrom <= to && d.DateTo >= from)
                                                                      );
                    if (bookings != null && bookings.Any())
                    {
                        int reservedQty = bookings.Sum(qty => qty.BookedQuantity);
                        valied.AvailableQtyInDates = Math.Max(res.Quantity - reservedQty, 0);
                    }
                    else
                        valied.AvailableQtyInDates = res.Quantity;
                }
                return valied;
            }

        /// <summary>
        /// Get Resource and Include it's Bookings
        /// </summary>
        /// <param name="_ResourcesRepo"></param>
        /// <param name="ofResource">id of needed resource</param>
        /// <returns>found resource or null </returns>
        private static async Task<Resource> FindResourceAndBookings(IResourceRepo _ResourcesRepo, int ofResource)
        {
            return (await _ResourcesRepo.GetEntitiesAsync(ToIncludeDSets: "Bookings", filter: res => res.ID == ofResource)).FirstOrDefault();
        }
        #endregion Validate
    }
}

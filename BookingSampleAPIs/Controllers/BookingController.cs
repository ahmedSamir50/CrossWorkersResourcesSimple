using AutoMapper;
using BookingSampleAPIs.Models;
using DataAccess.Entities;
using EmailService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReposAndServ.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSampleAPIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IResourceBookingsUWork _resourceBookingUOfWork;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailServ;

        public BookingController( IResourceBookingsUWork uWork, IMapper mapper, IEmailService emailService)
        {
            _resourceBookingUOfWork = uWork;
            _mapper = mapper;
            _emailServ = emailService;
        }

         //TODO Make Get Paginated 
        [HttpGet]
        public  async Task<IActionResult> Get()
        {
            IEnumerable<Resource> allResources = await _resourceBookingUOfWork.ResourcesRepo.GetAllAsync();
            var resourcesMapped = _mapper.Map<IEnumerable<ResourceVModel>>(allResources);
            return Ok(resourcesMapped);
        }

        [HttpGet("GetResWithBookings/{resId}")]
        public async Task<IActionResult> GetResWithBookings(int resId)
        {
            Resource resource = (await _resourceBookingUOfWork.ResourcesRepo
                              .GetEntitiesAsync(ToIncludeDSets: "Bookings", filter:res=>res.ID ==resId))
                              .FirstOrDefault();
            var resourcesMapped = _mapper.Map<ResourceVModel>(resource);
            return Ok(resourcesMapped);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBooking(ResourceBookingVModel newBooking)
        {
            Booking booking = _mapper.Map<ResourceBookingVModel, Booking>(newBooking);
            var resourceAvailability = await _resourceBookingUOfWork.ValidateResourceAvailability(newBooking.DateFrom, newBooking.DateTo, newBooking.ResIdNum);
            if (resourceAvailability.Availability)
            {
                if (resourceAvailability.AvailableQtyInDates < newBooking.BookedQuantity)
                    return BadRequest($"Only {resourceAvailability.AvailableQtyInDates} Of Resource available ");
                // available and quantity is sufficient 
                var added = await _resourceBookingUOfWork.BookingRepo.AddAsync(booking, true);
                 await _resourceBookingUOfWork.SaveChanges();
                // send email
                await _emailServ.SendEmail(email:GetMockedEmail(added.ID),
                                           callback: () => { Console.WriteLine("All Emails Send "); });
                return Ok(_mapper.Map<Booking, ResourceBookingVModel>(added));
            }
            else
                return BadRequest(resourceAvailability);
        }


        [HttpPost("ValidateResourceAvailability")]
        public async Task<IActionResult> ValidateResourceAvailability(ResourceBookingVModelBase query) {
            var resourceAvailability =await _resourceBookingUOfWork.ValidateResourceAvailability(query.DateFrom, query.DateTo, query.ResIdNum);
            return Ok(resourceAvailability);
        }

        // simple mocked email object as per task description
        private static Email GetMockedEmail(int id)
        {
            return new Email
            {
                Message = "Email Message",
                Subject = $"Resource Booking Confirmation FOR CREATED BOOKING WITH ID {id}",
                Recipients = new List<Recipient> {
                            new Recipient { RecipientEmail="admin@admin.com" ,
                                            RType = RecipientType.To ,
                                             RecipientName = "admin" }
                        }
            };
        }
    }
}

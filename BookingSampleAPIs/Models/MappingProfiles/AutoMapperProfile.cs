using AutoMapper;
using DataAccess.Entities;

namespace BookingSampleAPIs.Models.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        // Auto mapper mapping profile 
        // it's one place for simple example
        public AutoMapperProfile()
        {
            CreateMap<Booking, ResourceBookingVModel>()
              .ForMember(dest =>
            dest.ResIdNum,
            opt => opt.MapFrom(src => src.ResourceId))
              .ReverseMap();
            CreateMap<Resource, ResourceVModel>().ReverseMap();

        }
    }
}

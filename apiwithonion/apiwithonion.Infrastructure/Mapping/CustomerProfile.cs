using apiwithonion.Domain.Entities;
using apiwithonion.Infrastructure.ViewModel;
using AutoMapper;

namespace apiwithonion.Infrastructure.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, Customer>()
                .ForMember(dest => dest.Id,
                        opt => opt.MapFrom(src => src.CustomerId))
                .ReverseMap();
        }
    }
}

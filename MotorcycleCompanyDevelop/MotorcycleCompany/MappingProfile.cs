using AutoMapper;
using Entities.Models;
using shared.DataTransferObject;

namespace MotorcycleCompany
{
    public class MappingProfile : Profile

    {
        public MappingProfile()
        {
            CreateMap<Agency, AgencyDto>();
            //Forctorparan("FullDirection",opt=> opt.MapFrom(x=>string.Join(' ', x.Address, x.Neighborhood)));
        }
    }
}

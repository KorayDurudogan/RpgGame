using AutoMapper;
using RpgGame.Infrastructre.Models;
using RpgGame.Query.Api.Models;
using RpgGame.Query.Application.Models;

namespace RpgGame.Query.Api.Mappers
{
    public class ItemProfiles : Profile
    {
        public ItemProfiles()
        {
            CreateMap<GetCurrentItemSetRequest, GetCurrentItemSetRequestDto>();
            CreateMap<ItemQueryResponseDto, ItemQueryResponse>();
            CreateMap<Item, ItemQueryResponseDto>();
            CreateMap<GetSpecificTimeItemSetRequest, GetSpecificTimeItemSetRequestDto>();
        }
    }
}
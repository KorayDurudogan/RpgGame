using System;
using AutoMapper;
using RpgGame.Command.Api.Models;
using RpgGame.Command.Application.Models;
using RpgGame.Infrastructre.Models;

namespace RpgGame.Command.Api.Mappers
{
    public class ItemProfiles : Profile
    {
        public ItemProfiles()
        {
            CreateMap<WearItemRequest, WearItemRequestDto>();
            CreateMap<ItemWeared, ItemEvent>()
                .ForMember(dto => dto.Date, y 
                    => y.MapFrom(a => DateTime.Now));
            CreateMap<WearItemRequestDto, ItemWeared>();
        }
    }
}
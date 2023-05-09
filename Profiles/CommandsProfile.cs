using AutoMapper;
using DotNetSixMinimalApi.Dtos;
using DotNetSixMinimalApi.Models;

namespace DotNetSixMinimalApi.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source - Target 
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}
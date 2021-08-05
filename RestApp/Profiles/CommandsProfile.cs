using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    //mostenire bazata pe clasa
    public class CommandsProfile : Profile
    {
    //se creaza un constructor ptr clasa
    public CommandsProfile()
        {
                     // Source --> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();

        }
    }
}

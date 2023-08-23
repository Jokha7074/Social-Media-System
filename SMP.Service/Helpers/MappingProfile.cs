using AutoMapper;
using SMP.Data.Entities;
using SMP.Service.DTOs.Users;

namespace SMP.Service.Helpers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //User
        CreateMap<UserCreateDto, User>().ReverseMap();
        CreateMap<UserResultDto, User>().ReverseMap();
        CreateMap<UserUpadeDto, User>().ReverseMap();
    }
}

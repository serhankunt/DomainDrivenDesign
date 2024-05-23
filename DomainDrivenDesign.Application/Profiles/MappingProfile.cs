using AutoMapper;
using DomainDrivenDesign.Application.Features.Auth.Register;
using DomainDrivenDesign.Domain.Users;

namespace DomainDrivenDesign.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUserDto, RegisterCommand>();
    }
}


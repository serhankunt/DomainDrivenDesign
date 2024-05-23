using AutoMapper;
using DomainDrivenDesign.Domain.Users;
using DomainDrivenDesign.Domain.Users.Events;
using MediatR;
using TS.Result;

namespace DomainDrivenDesign.Application.Features.Auth.Register;

internal sealed class RegisterCommandHandler(IUserRepository userRepository,
    IMapper mapper,
    IMediator mediator) : IRequestHandler<RegisterCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        CreateUserDto createUserDto = mapper.Map<CreateUserDto>(request);
        User user = await userRepository.CreateAsync(createUserDto, cancellationToken);

        await mediator.Publish(new UserDomainEvent(user.Id));

        return Result<string>.Succeed("Register is successful");
    }
}


using FluentEmail.Core;
using MediatR;

namespace DomainDrivenDesign.Domain.Users.Events;

public sealed class SendConfirmEmailForUserDomainEvent(
    IUserRepository userRepository,
    IFluentEmail fluentEmail) : INotificationHandler<UserDomainEvent>
{
    public async Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
    {
        User? user = await userRepository.GetByIdAsnync(notification.UserId, cancellationToken);
        if(user is null)
        {
            throw new ArgumentException("We're trying to send confirmation email but can't find the user");
        }

        await fluentEmail
            .To(user.Email.Value)
            .Subject("Mail Confirm")
            .Body($"You can use this code for confirm your email. Code : {user.EmailConfirmCode}")
            .SendAsync(cancellationToken);

        //mail gönderme işlemi
    }
}


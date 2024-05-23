﻿namespace DomainDrivenDesign.Domain.Users;

public interface IUserRepository
{
    Task<User> CreateAsync(CreateUserDto request,CancellationToken cancellationToken = default);
    Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<User?> GetByIdAsnync(Guid id, CancellationToken cancellationToken = default);
}

using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Shared;
using System.Net.Sockets;

namespace DomainDrivenDesign.Domain.Users;

public sealed class User : Entity
{
    private User(Name fullName, Email email,Password password,Address address)
    {
        FullName = fullName;
        Email = email;
        Password = password;
        Address = address;
    }
    public Name FullName { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }
    public Address Address {  get; private set; }
    public static User CreateUser(string fullName, string email, string password, string country, string city, string town, string street, string fullAddress)
    {
        //Ýþ kurallarý
        User user = new(
            fullName: new(fullName),
            email: new(email),
            password: new(password),
            address: new(country, city, town, street, fullAddress)
            );
        return user;
    }
    public void ChangeFullName(string fullName)
    {
        FullName = new(fullName);
    }
}

public sealed record Email
{
    public string Value { get; init; }
    public Email(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException("You cannot enter empty email address");
        }

        if(!value.Contains("@"))
        {
            throw new ArgumentException("Please enter valid email address");
        }

        Value = value;
    }
}

public sealed record Password
{
    public string Value { get; init; }
    public Password(string value)
    {
        if(value.Length< 6)
        {
            throw new ArgumentException("Password must be greater than 6 characters");
        }        

        Value = value;
    }
}

public sealed record Address(
    string Country,
    string City,
    string Town,
    string Street,
    string FullAddress);

public interface IUserRepository
{
    Task<User> CreateAsync(CreateUserDto request,CancellationToken cancellationToken = default);
    Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default);
}

public sealed record CreateUserDto(
    string FullName, 
    string Email, 
    string Password,
    string Country, 
    string City, 
    string Town, 
    string Street, 
    string FullAddress);
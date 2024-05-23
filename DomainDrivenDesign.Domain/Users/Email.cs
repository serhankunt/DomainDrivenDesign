namespace DomainDrivenDesign.Domain.Users;

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

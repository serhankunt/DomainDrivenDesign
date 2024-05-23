namespace DomainDrivenDesign.Domain.Shared;

public sealed record Currency
{
    public static readonly Currency USD = new("USD");
    public static readonly Currency TRY = new("TRY");
    public Currency(string code)
    {
        Code = code;
    }
    public string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(p => p.Code == code) ?? throw new ArgumentException("Geçerli bir para birimi giriniz");
    }

    public static readonly IReadOnlyCollection<Currency> All = new[] { USD, TRY };
}

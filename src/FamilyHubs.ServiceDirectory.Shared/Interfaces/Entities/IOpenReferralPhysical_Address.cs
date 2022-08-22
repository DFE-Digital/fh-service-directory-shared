namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.Entities
{
    public interface IOpenReferralPhysical_Address
    {
        string Address_1 { get; init; }
        string? City { get; init; }
        string? Country { get; init; }
        string Postal_code { get; init; }
        string? State_province { get; init; }
    }
}
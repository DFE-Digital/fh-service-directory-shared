namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralPhysical_AddressRecord
    {
        string Address_1 { get; init; }
        string? City { get; init; }
        string? Country { get; init; }
        string Id { get; set; }
        string Postal_code { get; init; }
        string? State_province { get; init; }
    }
}
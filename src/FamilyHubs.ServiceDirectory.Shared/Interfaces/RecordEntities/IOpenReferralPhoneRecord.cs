namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralPhoneRecord
    {
        string Id { get; init; }
        string Number { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralPhoneRecord? other);
        int GetHashCode();
        string ToString();
    }
}
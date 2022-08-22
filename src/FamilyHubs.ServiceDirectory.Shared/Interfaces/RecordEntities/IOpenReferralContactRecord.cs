using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralContactRecord
    {
        string Id { get; set; }
        string Name { get; init; }
        ICollection<OpenReferralPhoneRecord>? Phones { get; init; }
        string Title { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralContactRecord? other);
        int GetHashCode();
        string ToString();
    }
}
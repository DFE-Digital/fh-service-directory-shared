using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralLanguageRecord
    {
        string Id { get; set; }
        string Language { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralLanguageRecord? other);
        int GetHashCode();
        string ToString();
    }
}
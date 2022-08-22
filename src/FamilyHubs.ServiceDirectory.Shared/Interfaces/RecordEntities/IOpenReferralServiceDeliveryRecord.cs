using FamilyHubs.ServiceDirectory.Shared.Enums;
using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralServiceDeliveryRecord
    {
        string Id { get; init; }
        ServiceDelivery ServiceDelivery { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralServiceDeliveryRecord? other);
        int GetHashCode();
        string ToString();
    }
}
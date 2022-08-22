using FamilyHubs.ServiceDirectory.Shared.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities
{
    public interface IOpenReferralServiceRecord
    {
        string? Accreditations { get; init; }
        DateTime? Assured_date { get; init; }
        string? Attending_access { get; init; }
        string? Attending_type { get; init; }
        ICollection<OpenReferralContactRecord>? Contacts { get; init; }
        ICollection<OpenReferralCost_OptionRecord>? Cost_options { get; init; }
        string? Deliverable_type { get; init; }
        string? Description { get; init; }
        ICollection<OpenReferralEligibilityRecord>? Eligibilities { get; init; }
        string? Email { get; init; }
        string? Fees { get; init; }
        string Id { get; init; }
        ICollection<OpenReferralLanguageRecord>? Languages { get; init; }
        string Name { get; init; }
        ICollection<OpenReferralService_AreaRecord>? Service_areas { get; init; }
        ICollection<OpenReferralServiceAtLocationRecord>? Service_at_locations { get; init; }
        ICollection<OpenReferralService_TaxonomyRecord>? Service_taxonomys { get; init; }
        ICollection<OpenReferralServiceDeliveryRecord>? ServiceDelivery { get; init; }
        string? Status { get; init; }
        string? Url { get; init; }

        bool Equals(object? obj);
        bool Equals(OpenReferralServiceRecord? other);
        int GetHashCode();
        string ToString();
    }
}
using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralContact;
using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralCostOption;
using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralEligibility;
using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralLanguage;
using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceArea;
using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceAtLocation;
using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceDeliveryEx;
using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralServiceTaxonomy;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralService;

public interface IOpenReferralServiceDto
{
    string? Accreditations { get; init; }
    DateTime? Assured_date { get; init; }
    string? Attending_access { get; init; }
    string? Attending_type { get; init; }
    ICollection<OpenReferralContactDto>? Contacts { get; init; }
    ICollection<OpenReferralCostOptionDto>? Cost_options { get; init; }
    string? Deliverable_type { get; init; }
    string? Description { get; init; }
    ICollection<OpenReferralEligibilityDto>? Eligibilities { get; init; }
    string? Email { get; init; }
    string? Fees { get; init; }
    string Id { get; init; }
    ICollection<OpenReferralLanguageDto>? Languages { get; init; }
    string Name { get; init; }
    ICollection<OpenReferralServiceAreaDto>? Service_areas { get; init; }
    ICollection<OpenReferralServiceAtLocationDto>? Service_at_locations { get; init; }
    ICollection<OpenReferralServiceTaxonomyDto>? Service_taxonomys { get; init; }
    ICollection<IOpenReferralServiceDeliveryExDto>? ServiceDelivery { get; init; }
    string? Status { get; init; }
    string? Url { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralServiceDto? other);
    int GetHashCode();
    string ToString();
}
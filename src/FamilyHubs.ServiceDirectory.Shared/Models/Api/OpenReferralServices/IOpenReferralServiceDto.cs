using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralCostOptions;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralEligibilitys;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLanguages;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAreas;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAtLocations;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceDeliverysEx;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceTaxonomys;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;

public interface IOpenReferralServiceDto
{
    string? Accreditations { get; init; }
    DateTime? Assured_date { get; init; }
    string? Attending_access { get; init; }
    string? Attending_type { get; init; }
    ICollection<IOpenReferralContactDto>? Contacts { get; init; }
    ICollection<IOpenReferralCostOptionDto>? Cost_options { get; init; }
    string? Deliverable_type { get; init; }
    string? Description { get; init; }
    ICollection<IOpenReferralEligibilityDto>? Eligibilities { get; init; }
    string? Email { get; init; }
    string? Fees { get; init; }
    string Id { get; init; }
    ICollection<IOpenReferralLanguageDto>? Languages { get; init; }
    string Name { get; init; }
    ICollection<IOpenReferralServiceAreaDto>? Service_areas { get; init; }
    ICollection<IOpenReferralServiceAtLocationDto>? Service_at_locations { get; init; }
    ICollection<IOpenReferralServiceTaxonomyDto>? Service_taxonomys { get; init; }
    ICollection<IOpenReferralServiceDeliveryExDto>? ServiceDelivery { get; init; }
    string? Status { get; init; }
    string? Url { get; init; }
}
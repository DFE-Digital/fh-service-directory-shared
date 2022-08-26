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
    ICollection<OpenReferralServiceDeliveryExDto>? ServiceDelivery { get; init; }
    string? Status { get; init; }
    string? Url { get; init; }
}
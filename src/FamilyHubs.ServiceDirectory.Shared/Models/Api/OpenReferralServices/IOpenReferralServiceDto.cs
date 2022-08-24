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
    string? Accreditations { get; set; }
    DateTime? Assured_date { get; set; }
    string? Attending_access { get; set; }
    string? Attending_type { get; set; }
    ICollection<IOpenReferralContactDto>? Contacts { get; set; }
    ICollection<IOpenReferralCostOptionDto>? Cost_options { get; set; }
    string? Deliverable_type { get; set; }
    string? Description { get; set; }
    ICollection<IOpenReferralEligibilityDto>? Eligibilities { get; set; }
    string? Email { get; set; }
    string? Fees { get; set; }
    string Id { get; set; }
    ICollection<IOpenReferralLanguageDto>? Languages { get; set; }
    string Name { get; set; }
    ICollection<IOpenReferralServiceAreaDto>? Service_areas { get; set; }
    ICollection<IOpenReferralServiceAtLocationDto>? Service_at_locations { get; set; }
    ICollection<IOpenReferralServiceTaxonomyDto>? Service_taxonomys { get; set; }
    ICollection<IOpenReferralServiceDeliveryExDto>? ServiceDelivery { get; set; }
    string? Status { get; set; }
    string? Url { get; set; }
}
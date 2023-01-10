using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralCostOptions;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralEligibilitys;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralHolidaySchedule;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLanguages;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralRegularSchedule;
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
    ICollection<OpenReferralContactDto>? Contacts { get; set; }
    ICollection<OpenReferralCostOptionDto>? Cost_options { get; set; }
    string? Deliverable_type { get; set; }
    string? Description { get; set; }
    ICollection<OpenReferralEligibilityDto>? Eligibilities { get; set; }
    string? Email { get; set; }
    string? Fees { get; set; }
    string Id { get; set; }
    public string OpenReferralOrganisationId { get; set; }
    ICollection<OpenReferralLanguageDto>? Languages { get; set; }
    string Name { get; set; }
    ICollection<OpenReferralServiceAreaDto>? Service_areas { get; set; }
    ICollection<OpenReferralServiceAtLocationDto>? Service_at_locations { get; set; }
    ICollection<OpenReferralServiceTaxonomyDto>? Service_taxonomys { get; set; }
    ICollection<OpenReferralServiceDeliveryExDto>? ServiceDelivery { get; set; }
    string? Status { get; set; }
    string? Url { get; set; }
    ICollection<OpenReferralRegularScheduleDto>? RegularSchedules { get; set; }
    ICollection<OpenReferralHolidayScheduleDto>? HolidaySchedules { get; set; }
}
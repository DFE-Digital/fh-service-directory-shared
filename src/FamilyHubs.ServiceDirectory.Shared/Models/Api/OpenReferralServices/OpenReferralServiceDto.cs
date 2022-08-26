using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralCostOptions;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralEligibilitys;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLanguages;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAreas;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAtLocations;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceDeliverysEx;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceTaxonomys;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;

public record OpenReferralServiceDto : IOpenReferralServiceDto
{
    public OpenReferralServiceDto() { }
    public OpenReferralServiceDto(
        string id,
        string name,
        string? description,
        string? accreditations,
        DateTime? assured_date,
        string? attending_access,
        string? attending_type,
        string? deliverable_type,
        string? status,
        string? url,
        string? email,
        string? fees,
        ICollection<OpenReferralServiceDeliveryExDto>? serviceDelivery,
        ICollection<OpenReferralEligibilityDto>? eligibilities,
        ICollection<OpenReferralContactDto>? contacts,
        ICollection<OpenReferralCostOptionDto> cost_options,
        ICollection<OpenReferralLanguageDto>? languages,
        ICollection<OpenReferralServiceAreaDto>? service_areas,
        ICollection<OpenReferralServiceAtLocationDto>? service_at_locations,
        ICollection<OpenReferralServiceTaxonomyDto>? service_taxonomys
    )
    {
        Id = id;
        Name = name;
        Description = description;
        Accreditations = accreditations;
        Assured_date = assured_date;
        Attending_access = attending_access;
        Attending_type = attending_type;
        Deliverable_type = deliverable_type;
        Status = status;
        Url = url;
        Email = email;
        Fees = fees;
        ServiceDelivery = serviceDelivery;
        Eligibilities = eligibilities;
        Contacts = contacts;
        Cost_options = cost_options;
        Languages = languages;
        Service_areas = service_areas;
        Service_at_locations = service_at_locations;
        Service_taxonomys = service_taxonomys;
    }

    public string Id { get; init; } = default!;
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public string? Accreditations { get; init; }
    public DateTime? Assured_date { get; init; }
    public string? Attending_access { get; init; }
    public string? Attending_type { get; init; }
    public string? Deliverable_type { get; init; }
    public string? Status { get; init; }
    public string? Url { get; init; }
    public string? Email { get; init; }
    public string? Fees { get; init; }
    public ICollection<OpenReferralServiceDeliveryExDto>? ServiceDelivery { get; init; }
    public ICollection<OpenReferralEligibilityDto>? Eligibilities { get; init; }
    public ICollection<OpenReferralContactDto>? Contacts { get; init; }
    public ICollection<OpenReferralCostOptionDto>? Cost_options { get; init; }
    public ICollection<OpenReferralLanguageDto>? Languages { get; init; }
    public ICollection<OpenReferralServiceAreaDto>? Service_areas { get; init; }
    public ICollection<OpenReferralServiceAtLocationDto>? Service_at_locations { get; init; }
    public ICollection<OpenReferralServiceTaxonomyDto>? Service_taxonomys { get; init; }
}

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
        ICollection<IOpenReferralServiceDeliveryExDto>? serviceDelivery,
        ICollection<IOpenReferralEligibilityDto>? eligibilities,
        ICollection<IOpenReferralContactDto>? contacts,
        ICollection<IOpenReferralCostOptionDto> cost_options,
        ICollection<IOpenReferralLanguageDto>? languages,
        ICollection<IOpenReferralServiceAreaDto>? service_areas,
        ICollection<IOpenReferralServiceAtLocationDto>? service_at_locations,
        ICollection<IOpenReferralServiceTaxonomyDto>? service_taxonomys
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

    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? Accreditations { get; set; }
    public DateTime? Assured_date { get; set; }
    public string? Attending_access { get; set; }
    public string? Attending_type { get; set; }
    public string? Deliverable_type { get; set; }
    public string? Status { get; set; }
    public string? Url { get; set; }
    public string? Email { get; set; }
    public string? Fees { get; set; }
    public ICollection<IOpenReferralServiceDeliveryExDto>? ServiceDelivery { get; set; }
    public ICollection<IOpenReferralEligibilityDto>? Eligibilities { get; set; }
    public ICollection<IOpenReferralContactDto>? Contacts { get; set; }
    public ICollection<IOpenReferralCostOptionDto>? Cost_options { get; set; }
    public ICollection<IOpenReferralLanguageDto>? Languages { get; set; }
    public ICollection<IOpenReferralServiceAreaDto>? Service_areas { get; set; }
    public ICollection<IOpenReferralServiceAtLocationDto>? Service_at_locations { get; set; }
    public ICollection<IOpenReferralServiceTaxonomyDto>? Service_taxonomys { get; set; }
}

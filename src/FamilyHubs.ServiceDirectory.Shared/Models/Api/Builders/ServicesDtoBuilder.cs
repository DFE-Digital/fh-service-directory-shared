using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralCostOptions;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralEligibilitys;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLanguages;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAreas;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAtLocations;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceDeliverysEx;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceTaxonomys;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.Builders;

public class ServicesDtoBuilder
{
    private IOpenReferralServiceDto _openReferralServiceDto;

    public ServicesDtoBuilder()
    {
        _openReferralServiceDto = new OpenReferralServiceDto();
    }

    public ServicesDtoBuilder WithMainProperties(string id, string name, string? description, string? accreditations, DateTime? assured_date, string? attending_access, string? attending_type, string? deliverable_type, string? status, string? url, string? email, string? fees)
    {
        _openReferralServiceDto.Id = id;
        _openReferralServiceDto.Name = name;
        _openReferralServiceDto.Description = description;
        _openReferralServiceDto.Accreditations = accreditations;
        _openReferralServiceDto.Assured_date = assured_date;
        _openReferralServiceDto.Attending_access = attending_access;
        _openReferralServiceDto.Attending_type = attending_type;
        _openReferralServiceDto.Deliverable_type = deliverable_type;
        _openReferralServiceDto.Status = status;
        _openReferralServiceDto.Url = url;
        _openReferralServiceDto.Email = email;
        _openReferralServiceDto.Fees = fees;
        return this;
    }

    public ServicesDtoBuilder WithServiceDelivery(ICollection<IOpenReferralServiceDeliveryExDto>? serviceDelivery)
    {
        _openReferralServiceDto.ServiceDelivery = serviceDelivery;
        return this;
    }

    public ServicesDtoBuilder WithEligibility(ICollection<IOpenReferralEligibilityDto>? eligibilities)
    {
        _openReferralServiceDto.Eligibilities = eligibilities;
        return this;
    }

    public ServicesDtoBuilder WithContact(ICollection<IOpenReferralContactDto>? contacts)
    {
        _openReferralServiceDto.Contacts = contacts;
        return this;
    }

    public ServicesDtoBuilder WithCostOption(ICollection<IOpenReferralCostOptionDto> cost_options)
    {
        _openReferralServiceDto.Cost_options = cost_options;
        return this;
    }

    public ServicesDtoBuilder WithLanguages(ICollection<IOpenReferralLanguageDto>? languages)
    {
        _openReferralServiceDto.Languages = languages;
        return this;
    }

    public ServicesDtoBuilder WithServiceAreas(ICollection<IOpenReferralServiceAreaDto>? service_areas)
    {
        _openReferralServiceDto.Service_areas = service_areas;
        return this;
    }

    public ServicesDtoBuilder WithServiceAtLocations(ICollection<IOpenReferralServiceAtLocationDto>? service_at_locations)
    {
        _openReferralServiceDto.Service_at_locations = service_at_locations;
        return this;
    }

    public ServicesDtoBuilder WithServiceTaxonomies(ICollection<IOpenReferralServiceTaxonomyDto>? service_taxonomys)
    {
        _openReferralServiceDto.Service_taxonomys = service_taxonomys;
        return this;
    }

    public IOpenReferralServiceDto Build()
    {
        return _openReferralServiceDto;
    }
}

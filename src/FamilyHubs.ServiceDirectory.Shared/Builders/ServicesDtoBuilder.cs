using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContactLinks;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralCostOptions;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralEligibilitys;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLanguages;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAreas;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAtLocations;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceDeliverysEx;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServices;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceTaxonomys;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.ServiceType;

namespace FamilyHubs.ServiceDirectory.Shared.Builders;

public class ServicesDtoBuilder
{
    private OpenReferralServiceDto _openReferralServiceDto;

    public ServicesDtoBuilder()
    {
        _openReferralServiceDto = new OpenReferralServiceDto();
    }

    public ServicesDtoBuilder WithMainProperties(string id, ServiceTypeDto serviceType, string organisationId, string name, string? description, string? accreditations, DateTime? assured_date, string? attending_access, string? attending_type, string? deliverable_type, string? status, string? url, string? email, string? fees, bool canFamilyChooseDeliveryLocation)
    {
        _openReferralServiceDto.Id = id;
        _openReferralServiceDto.ServiceType = serviceType;
        _openReferralServiceDto.OpenReferralOrganisationId = organisationId;
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
        _openReferralServiceDto.CanFamilyChooseDeliveryLocation = canFamilyChooseDeliveryLocation;
        return this;
    }

    public ServicesDtoBuilder WithServiceDelivery(ICollection<OpenReferralServiceDeliveryExDto>? serviceDelivery)
    {
        _openReferralServiceDto.ServiceDelivery = serviceDelivery;
        return this;
    }

    public ServicesDtoBuilder WithEligibility(ICollection<OpenReferralEligibilityDto>? eligibilities)
    {
        _openReferralServiceDto.Eligibilities = eligibilities;
        return this;
    }

    public ServicesDtoBuilder WithContact(ICollection<OpenReferralContactDto>? contactDtos)
    {
        if (contactDtos == null) return this;
        
        _openReferralServiceDto.ContactLinks ??= new List<OpenReferralContactLinkDto>();
            
        foreach (var contact in contactDtos)
        {
            _openReferralServiceDto.ContactLinks.Add(new OpenReferralContactLinkDto
            {
                Contact = contact,
                LinkId = _openReferralServiceDto.Id,
                LinkType = "Service"
            });
        }

        return this;
    }

    public ServicesDtoBuilder WithCostOption(ICollection<OpenReferralCostOptionDto> cost_options)
    {
        _openReferralServiceDto.Cost_options = cost_options;
        return this;
    }

    public ServicesDtoBuilder WithLanguages(ICollection<OpenReferralLanguageDto>? languages)
    {
        _openReferralServiceDto.Languages = languages;
        return this;
    }

    public ServicesDtoBuilder WithServiceAreas(ICollection<OpenReferralServiceAreaDto>? service_areas)
    {
        _openReferralServiceDto.Service_areas = service_areas;
        return this;
    }

    public ServicesDtoBuilder WithServiceAtLocations(ICollection<OpenReferralServiceAtLocationDto>? service_at_locations)
    {
        _openReferralServiceDto.Service_at_locations = service_at_locations;
        return this;
    }

    public ServicesDtoBuilder WithServiceTaxonomies(ICollection<OpenReferralServiceTaxonomyDto>? service_taxonomys)
    {
        _openReferralServiceDto.Service_taxonomys = service_taxonomys;
        return this;
    }

    public OpenReferralServiceDto Build()
    {
        return _openReferralServiceDto;
    }
}

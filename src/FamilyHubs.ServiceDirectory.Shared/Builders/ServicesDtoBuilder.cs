using FamilyHubs.ServiceDirectory.Shared.Dto;

namespace FamilyHubs.ServiceDirectory.Shared.Builders;

public class ServicesDtoBuilder
{
    private readonly ServiceDto _serviceDto;

    public ServicesDtoBuilder()
    {
        _serviceDto = new ServiceDto();
    }

    public ServicesDtoBuilder WithMainProperties(string id, ServiceTypeDto serviceType, string organisationId, string name, string? description, string? accreditations, DateTime? assuredDate, string? attendingAccess, string? attendingType, string? deliverableType, string? status, string? fees, bool canFamilyChooseDeliveryLocation)
    {
        _serviceDto.Id = id;
        _serviceDto.ServiceType = serviceType;
        _serviceDto.OrganisationId = organisationId;
        _serviceDto.Name = name;
        _serviceDto.Description = description;
        _serviceDto.Accreditations = accreditations;
        _serviceDto.AssuredDate = assuredDate;
        _serviceDto.AttendingAccess = attendingAccess;
        _serviceDto.AttendingType = attendingType;
        _serviceDto.DeliverableType = deliverableType;
        _serviceDto.Status = status;
        _serviceDto.Fees = fees;
        _serviceDto.CanFamilyChooseDeliveryLocation = canFamilyChooseDeliveryLocation;
        return this;
    }

    public ServicesDtoBuilder WithServiceDelivery(ICollection<ServiceDeliveryDto>? serviceDelivery)
    {
        _serviceDto.ServiceDeliveries = serviceDelivery;
        return this;
    }

    public ServicesDtoBuilder WithEligibility(ICollection<EligibilityDto>? eligibilities)
    {
        _serviceDto.Eligibilities = eligibilities;
        return this;
    }

    public ServicesDtoBuilder WithLinkContact(ICollection<LinkContactDto>? linkContacts)
    {
        _serviceDto.LinkContacts = linkContacts;
        return this;
    }

    public ServicesDtoBuilder WithCostOption(ICollection<CostOptionDto> costOptions)
    {
        _serviceDto.CostOptions = costOptions;
        return this;
    }

    public ServicesDtoBuilder WithLanguages(ICollection<LanguageDto>? languages)
    {
        _serviceDto.Languages = languages;
        return this;
    }

    public ServicesDtoBuilder WithServiceAreas(ICollection<ServiceAreaDto>? serviceAreas)
    {
        _serviceDto.ServiceAreas = serviceAreas;
        return this;
    }

    public ServicesDtoBuilder WithServiceAtLocations(ICollection<ServiceAtLocationDto>? serviceAtLocations)
    {
        _serviceDto.ServiceAtLocations = serviceAtLocations;
        return this;
    }

    public ServicesDtoBuilder WithServiceTaxonomies(ICollection<ServiceTaxonomyDto>? serviceTaxonomies)
    {
        _serviceDto.ServiceTaxonomies = serviceTaxonomies;
        return this;
    }

    public ServicesDtoBuilder WithFundings(ICollection<FundingDto>? fundings)
    {
        _serviceDto.Fundings = fundings;
        return this;
    }

    public ServiceDto Build()
    {
        return _serviceDto;
    }
}

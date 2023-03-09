using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace FamilyHubs.ServiceDirectory.Shared.Builders;

public class ServicesDtoBuilder
{
    private readonly ServiceDto _serviceDto;

    public ServicesDtoBuilder(string serviceOwnerReferenceId, ServiceType serviceType, long organisationId, string name, string? description, string? accreditations, DateTime? assuredDate, AttendingAccessType attendingAccess, AttendingType attendingType, DeliverableType deliverableType, ServiceStatusType status, string? fees, bool canFamilyChooseDeliveryLocation)
    {
        _serviceDto = new ServiceDto
        {
            ServiceOwnerReferenceId = serviceOwnerReferenceId,
            ServiceType = serviceType,
            OrganisationId = organisationId,
            Name = name,
            Description = description,
            Accreditations = accreditations,
            AssuredDate = assuredDate,
            AttendingAccess = attendingAccess,
            AttendingType = attendingType,
            DeliverableType = deliverableType,
            Status = status,
            Fees = fees,
            CanFamilyChooseDeliveryLocation = canFamilyChooseDeliveryLocation
        };
    }

    public ServicesDtoBuilder WithServiceDelivery(ICollection<ServiceDeliveryDto> serviceDelivery)
    {
        _serviceDto.ServiceDeliveries = serviceDelivery;
        return this;
    }

    public ServicesDtoBuilder WithEligibility(ICollection<EligibilityDto> eligibilities)
    {
        _serviceDto.Eligibilities = eligibilities;
        return this;
    }

    public ServicesDtoBuilder WithFundings(ICollection<FundingDto> fundings)
    {
        _serviceDto.Fundings = fundings;
        return this;
    }

    public ServicesDtoBuilder WithCostOption(ICollection<CostOptionDto> costOptions)
    {
        _serviceDto.CostOptions = costOptions;
        return this;
    }

    public ServicesDtoBuilder WithLanguages(ICollection<LanguageDto> languages)
    {
        _serviceDto.Languages = languages;
        return this;
    }

    public ServicesDtoBuilder WithServiceAreas(ICollection<ServiceAreaDto> serviceAreas)
    {
        _serviceDto.ServiceAreas = serviceAreas;
        return this;
    }

    public ServicesDtoBuilder WithLocations(ICollection<LocationDto> locations)
    {
        _serviceDto.Locations = locations;
        return this;
    }

    public ServicesDtoBuilder WithTaxonomies(ICollection<TaxonomyDto> taxonomies)
    {
        _serviceDto.Taxonomies = taxonomies;
        return this;
    }

    public ServicesDtoBuilder WithRegularSchedules(ICollection<RegularScheduleDto> regularSchedules)
    {
        _serviceDto.RegularSchedules = regularSchedules;
        return this;
    }

    public ServicesDtoBuilder WithHolidaySchedules(ICollection<HolidayScheduleDto> holidaySchedules)
    {
        _serviceDto.HolidaySchedules = holidaySchedules;
        return this;
    }

    public ServicesDtoBuilder WithContact(ICollection<ContactDto> contacts)
    {
        _serviceDto.Contacts = contacts;
        return this;
    }

    public ServicesDtoBuilder WithReview(ICollection<ReviewDto> reviews)
    {
        _serviceDto.Reviews = reviews;
        return this;
    }

    public ServiceDto Build()
    {
        return _serviceDto;
    }
}

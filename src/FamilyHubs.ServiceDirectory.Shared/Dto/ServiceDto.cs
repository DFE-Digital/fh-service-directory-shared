namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceDto
{
    public ServiceDto() { }
    public ServiceDto(
        string id,
        ServiceTypeDto serviceType,
        string organisationId,
        string name,
        string? description,
        string? accreditations,
        DateTime? assuredDate,
        string? attendingAccess,
        string? attendingType,
        string? deliverableType,
        string? status,
        string? fees,
        bool canFamilyChooseDeliveryLocation,
        ICollection<ServiceDeliveryDto>? serviceDeliveries,
        ICollection<EligibilityDto>? eligibilities,
        ICollection<FundingDto>? fundings,
        ICollection<CostOptionDto> costOptions,
        ICollection<LanguageDto>? languages,
        ICollection<ServiceAreaDto>? serviceAreas,
        ICollection<ServiceAtLocationDto>? serviceAtLocations,
        ICollection<ServiceTaxonomyDto>? serviceTaxonomies,
        ICollection<RegularScheduleDto>? regularSchedules,
        ICollection<HolidayScheduleDto>? holidaySchedules,
        ICollection<LinkContactDto>? linkContacts
    )
    {
        Id = id;
        ServiceType = serviceType;
        OrganisationId = organisationId;
        Name = name;
        Description = description;
        Accreditations = accreditations;
        AssuredDate = assuredDate;
        AttendingAccess = attendingAccess;
        AttendingType = attendingType;
        DeliverableType = deliverableType;
        Status = status;
        Fees = fees;
        CanFamilyChooseDeliveryLocation = canFamilyChooseDeliveryLocation;
        ServiceDeliveries = serviceDeliveries;
        Eligibilities = eligibilities;
        Fundings = fundings;
        CostOptions = costOptions;
        Languages = languages;
        ServiceAreas = serviceAreas;
        ServiceAtLocations = serviceAtLocations;
        ServiceTaxonomies = serviceTaxonomies;
        RegularSchedules = regularSchedules;
        HolidaySchedules = holidaySchedules;
        LinkContacts = linkContacts;
    }

    public string Id { get; set; } = default!;
    public ServiceTypeDto ServiceType { get; set; } = default!;
    public string OrganisationId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public string? Accreditations { get; set; }
    public DateTime? AssuredDate { get; set; }
    public string? AttendingAccess { get; set; }
    public string? AttendingType { get; set; }
    public string? DeliverableType { get; set; }
    public string? Status { get; set; }
    public string? Fees { get; set; }
    public double? Distance { get; set; } = default;
    public bool CanFamilyChooseDeliveryLocation { get; set; }
    public ICollection<ServiceDeliveryDto>? ServiceDeliveries { get; set; }
    public ICollection<EligibilityDto>? Eligibilities { get; set; }
    public ICollection<FundingDto>? Fundings { get; set; }
    public ICollection<CostOptionDto>? CostOptions { get; set; }
    public ICollection<LanguageDto>? Languages { get; set; }
    public ICollection<ServiceAreaDto>? ServiceAreas { get; set; }
    public ICollection<ServiceAtLocationDto>? ServiceAtLocations { get; set; }
    public ICollection<ServiceTaxonomyDto>? ServiceTaxonomies { get; set; }
    public ICollection<RegularScheduleDto>? RegularSchedules { get; set; }
    public ICollection<HolidayScheduleDto>? HolidaySchedules { get; set; }
    public ICollection<LinkContactDto>? LinkContacts { get; set; }
}

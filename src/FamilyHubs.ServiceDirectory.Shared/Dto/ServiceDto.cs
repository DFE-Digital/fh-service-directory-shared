// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceDto
{
    public required long Id { get; set; }
    public required string ServiceOwnerReferenceId { get; set; }
    public required ServiceType ServiceType { get; set; }
    public required long OrganisationId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public ServiceStatusType Status { get; set; }
    public string? Fees { get; set; }
    public string? Accreditations { get; set; }
    public DeliverableType DeliverableType { get; set; }
    public DateTime? AssuredDate { get; set; }
    public AttendingType AttendingType { get; set; }
    public AttendingAccessType AttendingAccess { get; set; }
    public double? Distance { get; set; }
    public bool CanFamilyChooseDeliveryLocation { get; set; }
    public ICollection<ServiceDeliveryDto> ServiceDeliveries { get; set; } = new List<ServiceDeliveryDto>();
    public ICollection<EligibilityDto> Eligibilities { get; set; } = new List<EligibilityDto>();
    public ICollection<FundingDto> Fundings { get; set; } = new List<FundingDto>();
    public ICollection<CostOptionDto> CostOptions { get; set; } = new List<CostOptionDto>();
    public ICollection<LanguageDto> Languages { get; set; } = new List<LanguageDto>();
    public ICollection<ServiceAreaDto> ServiceAreas { get; set; } = new List<ServiceAreaDto>();
    public ICollection<LocationDto> Locations { get; set; } = new List<LocationDto>();
    public ICollection<TaxonomyDto> Taxonomies { get; set; } = new List<TaxonomyDto>();
    public ICollection<RegularScheduleDto> RegularSchedules { get; set; } = new List<RegularScheduleDto>();
    public ICollection<HolidayScheduleDto> HolidaySchedules { get; set; } = new List<HolidayScheduleDto>();
    public ICollection<ReviewDto> Reviews { get; set; } = new List<ReviewDto>();
    public ICollection<ContactDto> Contacts { get; set; } = new List<ContactDto>();
}
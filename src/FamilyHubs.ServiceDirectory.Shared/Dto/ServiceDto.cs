using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CS8607
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record ServiceDto : OrganisationDtoBase<long>
{
    public required string ServiceOwnerReferenceId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? Fees { get; set; }
    public string? Accreditations { get; set; }
    public DateTime? AssuredDate { get; set; }
    public required ServiceType ServiceType { get; set; }
    public ServiceStatusType Status { get; set; }
    public DeliverableType DeliverableType { get; set; }
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
    public override int GetHashCode()
    {
        return
            EqualityComparer<string>.Default.GetHashCode(ServiceOwnerReferenceId) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Description) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Fees) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Accreditations) * -1521134295 +
            EqualityComparer<DateTime?>.Default.GetHashCode(AssuredDate) * -1521134295 +
            EqualityComparer<Enum>.Default.GetHashCode(ServiceType) * -1521134295 +
            EqualityComparer<Enum>.Default.GetHashCode(Status) * -1521134295 +
            EqualityComparer<Enum>.Default.GetHashCode(DeliverableType) * -1521134295 +
            EqualityComparer<Enum>.Default.GetHashCode(AttendingType) * -1521134295 +
            EqualityComparer<Enum>.Default.GetHashCode(AttendingAccess) * -1521134295 +
            EqualityComparer<bool>.Default.GetHashCode(CanFamilyChooseDeliveryLocation) * -1521134295
            ;
    }

    public virtual bool Equals(ServiceDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<string>.Default.Equals(ServiceOwnerReferenceId, other.ServiceOwnerReferenceId) &&
            EqualityComparer<string>.Default.Equals(Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(Description, other.Description) &&
            EqualityComparer<string?>.Default.Equals(Fees, other.Fees) &&
            EqualityComparer<string?>.Default.Equals(Accreditations, other.Accreditations) &&
            EqualityComparer<DateTime?>.Default.Equals(AssuredDate, other.AssuredDate) &&
            EqualityComparer<Enum>.Default.Equals(ServiceType, other.ServiceType) &&
            EqualityComparer<Enum>.Default.Equals(Status, other.Status) &&
            EqualityComparer<Enum>.Default.Equals(DeliverableType, other.DeliverableType) &&
            EqualityComparer<Enum>.Default.Equals(AttendingType, other.AttendingType) &&
            EqualityComparer<Enum>.Default.Equals(AttendingAccess, other.AttendingAccess) &&
            EqualityComparer<bool>.Default.Equals(CanFamilyChooseDeliveryLocation, other.CanFamilyChooseDeliveryLocation)
            ;
    }
}
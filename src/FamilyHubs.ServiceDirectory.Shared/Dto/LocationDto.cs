using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CS8604

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record LocationDto : DtoBase<long>
{
    public required LocationType LocationType { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required double Latitude { get; set; }
    public required double Longitude { get; set; }
    public required string Address1 { get; set; }
    public string? Address2 { get; set; }
    public required string City { get; set; }
    public required string PostCode { get; set; }
    public required string StateProvince { get; set; }
    public required string Country { get; set; }
    public double? Distance { get; set; }

    public ICollection<AccessibilityForDisabilitiesDto> AccessibilityForDisabilities { get; set; } = new List<AccessibilityForDisabilitiesDto>();
    public ICollection<RegularScheduleDto> RegularSchedules { get; set; } = new List<RegularScheduleDto>();
    public ICollection<HolidayScheduleDto> HolidaySchedules { get; set; } = new List<HolidayScheduleDto>();
    public ICollection<ContactDto> Contacts { get; set; } = new List<ContactDto>();

    public override int GetHashCode()
    {
        return
            EqualityComparer<Enum>.Default.GetHashCode(LocationType) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Description) * -1521134295 +
            EqualityComparer<double>.Default.GetHashCode(Latitude) * -1521134295 +
            EqualityComparer<double>.Default.GetHashCode(Longitude) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Address1) * -1521134295 +
            EqualityComparer<string?>.Default.GetHashCode(Address2) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(City) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(PostCode) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(StateProvince) * -1521134295 +
            EqualityComparer<string>.Default.GetHashCode(Country) * -1521134295 
            ;
    }

    public virtual bool Equals(LocationDto? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other))
            return true;

        return
            EqualityComparer<Enum>.Default.Equals(LocationType, other.LocationType) &&
            EqualityComparer<string>.Default.Equals(Name, other.Name) &&
            EqualityComparer<string?>.Default.Equals(Description, other.Description) &&
            EqualityComparer<double>.Default.Equals(Latitude, other.Latitude) &&
            EqualityComparer<double>.Default.Equals(Longitude, other.Longitude) &&
            EqualityComparer<string>.Default.Equals(Address1, other.Address1) &&
            EqualityComparer<string?>.Default.Equals(Address2, other.Address2) &&
            EqualityComparer<string>.Default.Equals(City, other.City) &&
            EqualityComparer<string>.Default.Equals(PostCode, other.PostCode) &&
            EqualityComparer<string>.Default.Equals(StateProvince, other.StateProvince) &&
            EqualityComparer<string>.Default.Equals(Country, other.Country)
            ;
    }
}
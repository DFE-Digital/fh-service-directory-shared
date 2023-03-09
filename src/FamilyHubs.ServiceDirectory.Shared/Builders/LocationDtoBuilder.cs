using FamilyHubs.ServiceDirectory.Shared.Dto;
using FamilyHubs.ServiceDirectory.Shared.Enums;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace FamilyHubs.ServiceDirectory.Shared.Builders;

public class LocationDtoBuilder
{
    private readonly LocationDto _locationDto;

    public LocationDtoBuilder(long id, LocationType locationType, string name, double latitude, double longitude, string address1, string city, string postCode, string stateProvince, string country, string? description, string? address2)
    {
        _locationDto = new LocationDto
        {
            Id = id,
            LocationType = locationType,
            Name = name,
            Latitude = latitude,
            Longitude = longitude,
            Address1 = address1,
            City = city,
            PostCode = postCode,
            StateProvince = stateProvince,
            Country = country,
            Description = description,
            Address2 = address2
        };
    }

    public LocationDtoBuilder WithRegularSchedules(ICollection<RegularScheduleDto> regularSchedules)
    {
        _locationDto.RegularSchedules = regularSchedules;
        return this;
    }

    public LocationDtoBuilder WithAccessibilityForDisabilities(ICollection<AccessibilityForDisabilitiesDto> accessibilityForDisabilities)
    {
        _locationDto.AccessibilityForDisabilities = accessibilityForDisabilities;
        return this;
    }

    public LocationDtoBuilder WithHolidaySchedules(ICollection<HolidayScheduleDto> holidaySchedules)
    {
        _locationDto.HolidaySchedules = holidaySchedules;
        return this;
    }

    public LocationDtoBuilder WithContact(ICollection<ContactDto> contacts)
    {
        _locationDto.Contacts = contacts;
        return this;
    }

    public LocationDto Build()
    {
        return _locationDto;
    }
}

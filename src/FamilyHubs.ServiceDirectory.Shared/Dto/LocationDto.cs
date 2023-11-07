﻿using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record LocationDto : DtoBase
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
}
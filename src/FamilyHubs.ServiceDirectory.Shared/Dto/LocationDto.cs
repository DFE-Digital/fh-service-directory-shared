﻿using FamilyHubs.ServiceDirectory.Shared.Dto.BaseDto;
using FamilyHubs.ServiceDirectory.Shared.Enums;

namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record LocationDto : DtoBase
{
    public long? OrganisationId { get; set; }
    public required LocationTypeCategory LocationTypeCategory { get; set; }
    public string? Name { get; set; }
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
    public required LocationType LocationType { get; set; }
    public string? AddressType { get; set; }
    public string? AlternateName { get; set; }
    public string? Attention { get; set; }
    public string? Region { get; set; }
    public string? Transportation { get; set; }
    public string? Url { get; set; }
    public string? ExternalIdentifier { get; set; }
    public string? ExternalIdentifierType { get; set; }

    public ICollection<AccessibilityForDisabilitiesDto> AccessibilityForDisabilities { get; set; } = new List<AccessibilityForDisabilitiesDto>();
    public ICollection<ScheduleDto> Schedules { get; set; } = new List<ScheduleDto>();
    public ICollection<ContactDto> Contacts { get; set; } = new List<ContactDto>();
}
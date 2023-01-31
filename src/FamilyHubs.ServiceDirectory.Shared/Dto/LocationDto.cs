﻿namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public record LocationDto
{
    public LocationDto() { }
    public LocationDto(string id,
        string name,
        string? description,
        double latitude,
        double longitude,
        ICollection<PhysicalAddressDto>? physicalAddresses,
        ICollection<LinkTaxonomyDto>? linkTaxonomies, 
        ICollection<LinkContactDto>? linkContacts)
    {
        Id = id;
        Name = name;
        Description = description;
        Latitude = latitude;
        Longitude = longitude;
        PhysicalAddresses = physicalAddresses;
        LinkTaxonomies = linkTaxonomies;
        LinkContacts = linkContacts;
    }
    public string Id { get; init; } = default!;
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public double Latitude { get; init; }
    public double Longitude { get; init; }
    public double? Distance { get; set; } = default;
    public ICollection<PhysicalAddressDto>? PhysicalAddresses { get; init; }
    public ICollection<LinkTaxonomyDto>? LinkTaxonomies { get; set; }
    public ICollection<LinkContactDto>? LinkContacts { get; set; }
}


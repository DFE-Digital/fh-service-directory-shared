﻿namespace FamilyHubs.ServiceDirectory.Shared.Dto;

public class PhysicalAddressDto
{
    public PhysicalAddressDto() { }
    public PhysicalAddressDto(
        string id,
        string address1,
        string? city,
        string postCode,
        string? country,
        string? stateProvince
    )
    {
        Id = id;
        Address1 = address1;
        City = city;
        PostCode = postCode;
        Country = country;
        StateProvince = stateProvince;
    }

    public string Id { get; set; } = default!;
    public string Address1 { get; init; } = default!;
    public string? City { get; init; }
    public string PostCode { get; init; } = default!;
    public string? Country { get; init; }
    public string? StateProvince { get; init; }
}


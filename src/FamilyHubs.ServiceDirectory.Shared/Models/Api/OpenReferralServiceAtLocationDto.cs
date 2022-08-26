namespace FamilyHubs.ServiceDirectory.Shared.Models.Api;

public record OpenReferralServiceAtLocationDto
{ 
    public OpenReferralServiceAtLocationDto() { }
    public OpenReferralServiceAtLocationDto(
        string id,
        OpenReferralLocationDto location
        )
    {
        Id = id;
        Location = location;
    }

    public string Id { get; set; } = default!;
    public OpenReferralLocationDto Location { get; init; } = default!;
}


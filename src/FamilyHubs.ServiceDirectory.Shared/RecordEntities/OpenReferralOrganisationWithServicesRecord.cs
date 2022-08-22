using FamilyHubs.ServiceDirectory.Shared.Interfaces.RecordEntities;

namespace FamilyHubs.ServiceDirectory.Shared.RecordEntities;

public record OpenReferralOrganisationWithServicesRecord : IOpenReferralOrganisationWithServicesRecord
{
    private OpenReferralOrganisationWithServicesRecord()
    {

    }
    public OpenReferralOrganisationWithServicesRecord(
        string id,
        string? name,
        string? description,
        string? logo,
        string? uri,
        string? url,
        ICollection<IOpenReferralServiceRecord>? services)
    {
        Id = id;
        Name = name;
        Description = description;
        Logo = logo;
        Uri = uri;
        Url = url;
        Services = services;
    }

    public string Id { get; init; } = default!;
    public string? Name { get; init; }
    public string? Description { get; init; }
    public string? Logo { get; init; }
    public string? Uri { get; init; }
    public string? Url { get; init; }

    public virtual ICollection<IOpenReferralServiceRecord>? Services { get; set; } = default!;

}


using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLinkContacts;

public record OpenReferralLinkContactDto : IOpenReferralLinkContactDto
{
    public OpenReferralLinkContactDto() { }
    public OpenReferralLinkContactDto(
        string id,
        string linkType,
        string linkId,
        OpenReferralContactDto contact
    )
    {
        Id = id;
        LinkType = linkType;
        LinkId = linkId;
        Contact = contact;
    }

    public string Id { get; set; } = default!;
    public string LinkType { get; set; } = default!;
    public string LinkId { get; set; } = default!;
    public OpenReferralContactDto Contact { get; set; } = default!;
}

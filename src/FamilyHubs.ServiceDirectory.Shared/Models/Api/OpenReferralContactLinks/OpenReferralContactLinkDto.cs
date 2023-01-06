using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContactLinks;

public record OpenReferralContactLinkDto : IOpenReferralContactLinkDto
{
    public OpenReferralContactLinkDto() { }
    public OpenReferralContactLinkDto(
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

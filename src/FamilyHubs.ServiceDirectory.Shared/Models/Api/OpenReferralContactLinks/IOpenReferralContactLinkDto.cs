using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContactLinks;

public interface IOpenReferralContactLinkDto
{
    string Id { get; set; }
    string LinkType { get; set; }
    string LinkId { get; set; }
    OpenReferralContactDto Contact { get; set; }
}
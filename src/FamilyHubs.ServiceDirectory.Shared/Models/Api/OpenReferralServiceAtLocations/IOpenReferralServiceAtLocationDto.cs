using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLinkContacts;
using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralLocations;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralServiceAtLocations;

public interface IOpenReferralServiceAtLocationDto
{
    string Id { get; set; }
    OpenReferralLocationDto Location { get; init; }
    ICollection<OpenReferralLinkContactDto>? LinkContacts { get; set; }
}
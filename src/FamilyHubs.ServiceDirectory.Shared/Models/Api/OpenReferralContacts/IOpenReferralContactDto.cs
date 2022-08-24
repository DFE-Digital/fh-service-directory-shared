using FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralPhones;

namespace FamilyHubs.ServiceDirectory.Shared.Models.Api.OpenReferralContacts;

public interface IOpenReferralContactDto
{
    string Id { get; set; }
    string Name { get; init; }
    ICollection<IOpenReferralPhoneDto>? Phones { get; init; }
    string Title { get; init; }
}
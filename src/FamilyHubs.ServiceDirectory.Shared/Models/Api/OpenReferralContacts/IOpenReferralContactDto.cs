using FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralPhone;

namespace FamilyHubs.ServiceDirectory.Shared.Models.OpenReferralContact;

public interface IOpenReferralContactDto
{
    string Id { get; set; }
    string Name { get; init; }
    ICollection<IOpenReferralPhoneDto>? Phones { get; init; }
    string Title { get; init; }

    bool Equals(object? obj);
    bool Equals(OpenReferralContactDto? other);
    int GetHashCode();
    string ToString();
}